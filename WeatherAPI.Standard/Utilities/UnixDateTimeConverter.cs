using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeatherAPI.Standard.Utilities
{
    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;

        public DateTimeStyles DateTimeStyles
        {
            get { return _dateTimeStyles; }
            set { _dateTimeStyles = value; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            double text;
            if (value is DateTime)
            {
                DateTime dateTime = (DateTime)value;

                if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                    || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
                {
                    dateTime = dateTime.ToUniversalTime();
                }
                text = dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            }
            else
            {
                throw new JsonSerializationException("Unexpected value when converting date. Expected DateTime.");
            }

            writer.WriteValue(text);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {

            if (reader.TokenType != JsonToken.Integer)
            {
                throw new JsonSerializationException("Unexpected token");
            }
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double.Parse(reader.Value.ToString()));
        }
    }
}