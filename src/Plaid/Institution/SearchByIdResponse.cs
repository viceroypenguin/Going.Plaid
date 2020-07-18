using Newtonsoft.Json;

namespace Going.Plaid.Institution
{
    /// <summary>
    /// Represents a response from plaid's '/institutions/get_by_id' endpoints. The '/institutions/get_by_id' endpoint to retrieve a <see cref="Entity.Institution"/> with the specified id.
    /// </summary>
    /// <seealso cref="Going.Plaid.ResponseBase" />
    public class SearchByIdResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the institution.
        /// </summary>
        /// <value>The institution.</value>
        [JsonProperty("institution")]
        public Entity.Institution Institution { get; set; }
    }
}