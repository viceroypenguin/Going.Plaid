using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gigobyte.Plaid.Contract
{
    [JsonObject]
    public class Mfa
    {
        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        /// <value>The question.</value>
        [JsonProperty("question")]
        public string Question { get; set; }
        
        /// <summary>
        /// Gets or sets the mask of the phone or email when response is "list".
        /// </summary>
        /// <value>The mask.</value>
        [JsonProperty("mask")]
        public SendOption Mask { get; set; }
    }
}