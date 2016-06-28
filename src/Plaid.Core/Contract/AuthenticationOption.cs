using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract

{
    /// <summary>
    /// Represents a potential delivery method for a code-based MFA requirement.
    /// </summary>
    [JsonObject]
    public class AuthenticationOption
    {
        /// <summary>
        /// Gets or sets the mask.
        /// </summary>
        /// <value>The mask.</value>
        /// <example>t..t@plaid.com</example>
        [JsonProperty("mask")]
        public string Mask { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        /// <example>type":"email</example>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}