using Newtonsoft.Json;

namespace Acklann.Plaid.Institution
{
    /// <summary>
    /// Represents a request for plaid's '/institutions/search' endpoints. The '/institutions/search' endpoint to retrieve a complete list of supported institutions that match the query.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.SerializableContent" />
    public class SearchRequest : SerializableContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest"/> class.
        /// </summary>
        public SearchRequest()
        {
            NullValueHandling = NullValueHandling.Include;
        }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>The query.</value>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the supported products.
        /// </summary>
        /// <value>The products.</value>
        [JsonProperty("products")]
        public string[] Products { get; set; }

        /// <summary>
        /// Gets or sets the public key.
        /// </summary>
        /// <value>The public key.</value>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
    }
}