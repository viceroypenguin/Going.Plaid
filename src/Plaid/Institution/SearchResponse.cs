using Acklann.Plaid.Entity;
using Newtonsoft.Json;

namespace Acklann.Plaid.Institution
{
    /// <summary>
    /// Represents a request for plaid's '/institutions/search' endpoints. The '/institutions/search' endpoint to retrieve a complete list of supported institutions that match the query.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class SearchResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the institutions.
        /// </summary>
        /// <value>The institutions.</value>
        [JsonProperty("institutions")]
        public Entity.Institution[] Institutions { get; set; }
    }
}