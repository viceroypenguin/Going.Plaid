using Newtonsoft.Json;
using System.Net;

namespace Acklann.Plaid
{
    /// <summary>
    /// Provides common members for all Plaid API responses.
    /// </summary>
    public abstract class ResponseBase
    {
#if DEBUG
        public string RawJsonForDebugging;
#endif
        /// <summary>
        /// The Error
        /// </summary>
        public Exceptions.PlaidException Exception;

        /// <summary>
        /// Gets or sets the request identifier.
        /// </summary>
        /// <value>The request identifier.</value>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets the http status code.
        /// </summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether this instance is success status code.
        /// </summary>
        /// <value><c>true</c> if this instance is success status code; otherwise, <c>false</c>.</value>
        public bool IsSuccessStatusCode
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }
    }
}