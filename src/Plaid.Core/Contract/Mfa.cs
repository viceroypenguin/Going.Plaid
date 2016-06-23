using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    [JsonObject]
    public class Mfa
    {
        /// <summary>
        /// Gets or sets the call to action message for dealing with the MFA.
        /// </summary>
        /// <value>The message.</value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the MFA question.
        /// </summary>
        /// <value>The question.</value>
        [JsonProperty("question")]
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the mask of the phone or email when response is "list".
        /// </summary>
        /// <value>The mask.</value>
        [JsonProperty()]
        public DeliveryOption Options { get; set; }
    }
}