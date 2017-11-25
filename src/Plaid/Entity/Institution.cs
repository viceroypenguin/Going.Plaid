using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Represents a banking institution.
    /// </summary>
    public class Institution
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("institution_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has Multi-Factor Authentication.
        /// </summary>
        /// <value><c>true</c> if this instance has Multi-Factor Authentication; otherwise, <c>false</c>.</value>
        [JsonProperty("has_mfa")]
        public bool HasMfa { get; set; }

        /// <summary>
        /// Gets or sets the Multi-Factor Authentication selections.
        /// </summary>
        /// <value>The mfa selections.</value>
        [JsonProperty("mfa")]
        public string[] MfaSelections { get; set; }

        /// <summary>
        /// Gets or sets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        [JsonProperty("credentials")]
        public Credential[] Credentials { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>The products.</value>
        [JsonProperty("products")]
        public string[] Products { get; set; }

        /// <summary>
        /// Represents an <see cref="Institution"/> login credentials.
        /// </summary>
        public struct Credential
        {
            /// <summary>
            /// Gets or sets the label.
            /// </summary>
            /// <value>The label.</value>
            [JsonProperty("label")]
            public string Label { get; set; }

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the type of the data.
            /// </summary>
            /// <value>The type of the data.</value>
            [JsonProperty("type")]
            public string DataType { get; set; }
        }
    }
}