using WeatherAPI.Standard.Http.Request;
using WeatherAPI.Standard.Http.Response;

namespace WeatherAPI.Standard.Http.Client
{
    /// <summary>
    /// Represents the contextual information of HTTP request and response
    /// </summary>
    public class HttpContext
    {
        /// <summary>
        /// The http request in the current context
        /// </summary>
        public HttpRequest Request { get; set; }

        /// <summary>
        /// The http response in the current context
        /// </summary>
        public HttpResponse Response { get; set; }

        /// <summary>
        /// Constructor to initialize the context with http request and response information
        /// </summary>
        /// <param name="request">The http request in the current context</param>
        /// <param name="response">The http response in the current context</param>
        public HttpContext(HttpRequest request, HttpResponse response)
        {
            Request = request;
            Response = response;
        }
    }
}
