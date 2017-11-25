using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a response from plaid's drop-in authentication module.
    /// </summary>
    public class PlaidLinkResponse
    {
        /// <summary>
        /// Gets or sets the public_token.
        /// </summary>
        /// <value>The public token.</value>
        [JsonProperty("public_token")]
        public string PublicToken { get; set; }

        /// <summary>
        /// Gets or sets the link session identifier.
        /// </summary>
        /// <value>The link session identifier.</value>
        [JsonProperty("link_session_id")]
        public string LinkSessionId { get; set; }

        /// <summary>
        /// Gets or sets the accounts info.
        /// </summary>
        /// <value>The accounts.</value>
        [JsonProperty("accounts")]
        public AccountInfo[] Accounts { get; set; }

        /// <summary>
        /// Gets or sets the institution.
        /// </summary>
        /// <value>The institution.</value>
        [JsonProperty("institution")]
        public InstitutionInfo Institution { get; set; }

        /// <summary>
        /// Represents an <see cref="Entity.Account"/> metadata.
        /// </summary>
        public struct AccountInfo
        {
            /// <summary>
            /// Gets or sets the <see cref="Entity.Account"/> identifier.
            /// </summary>
            /// <value>The identifier.</value>
            [JsonProperty("id")]
            public string Id { get; set; }

            /// <summary>
            /// Gets or sets the <see cref="Entity.Account"/> name.
            /// </summary>
            /// <value>The name.</value>
            [JsonProperty("name")]
            public string Name { get; set; }
        }

        /// <summary>
        /// Represents an <see cref="Entity.Institution"/> metadata.
        /// </summary>
        public struct InstitutionInfo
        {
            /// <summary>
            /// Gets or sets the <see cref="Entity.Institution"/> identifier.
            /// </summary>
            /// <value>The identifier.</value>
            [JsonProperty("institution_id")]
            public string Id { get; set; }

            /// <summary>
            /// Gets or sets the <see cref="Entity.Institution"/> name.
            /// </summary>
            /// <value>The name.</value>
            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}