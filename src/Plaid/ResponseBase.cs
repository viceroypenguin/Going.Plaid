using Newtonsoft.Json;
using System.Net;

namespace Acklann.Plaid
{
    public abstract class ResponseBase
    {
#if DEBUG
        public string RawJsonForDebugging;
#endif
        public Exceptions.PlaidException Exception;

        /// <summary>
        /// Gets or sets the request identifier.
        /// </summary>
        /// <value>The request identifier.</value>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        public HttpStatusCode StatusCode { get; internal set; }

        public bool IsSuccessStatusCode
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }
    }
}