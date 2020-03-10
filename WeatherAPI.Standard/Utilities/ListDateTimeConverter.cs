using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeatherAPI.Standard.Utilities
{
    class ListDateTimeConverter : JsonConverter
    {
        public ListDateTimeConverter()
        {
            Converter = new IsoDateTimeConverter();
        }
        public ListDateTimeConverter(Type Converter)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(Converter);
        }
        public ListDateTimeConverter(Type Converter,string format)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(Converter,format);
        }
        public JsonConverter Converter { get; set; }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(Converter);
            serializer.Serialize(writer,value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(Converter);
            return serializer.Deserialize(reader, objectType);
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(List<DateTime>)||objectType == typeof(DateTime) || objectType == typeof(List<DateTimeOffset>)||objectType == typeof(DateTimeOffset))
                return true;
            else
                return false;
        }
    }
}