using Newtonsoft.Json;

namespace Acklann.Plaid.Institution
{
    /// <summary>
    /// Represents a request for plaid's '/institutions/get_by_id' endpoint. The '/institutions/get_by_id' endpoint to retrieve a <see cref="Entity.Institution"/> with the specified id.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.SerializableContent" />
    public class SearchByIdRequest : SerializableContent
    {
        /// <summary>
        /// Gets or sets the <see cref="Entity.Institution"/> identifier.
        /// </summary>
        /// <value>The institution identifier.</value>
        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// Gets or sets the public_key.
        /// </summary>
        /// <value>The public key.</value>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
    }
}