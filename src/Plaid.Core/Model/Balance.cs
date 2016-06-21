using Newtonsoft.Json;

namespace Gigobyte.Plaid.Model
{
    /// <summary>
    /// Represents an account balance.
    /// </summary>
    /// <remarks>
    /// The Current Balance is the total amount of funds in the account. The Available Balance is the
    /// Current Balance less any outstanding holds or debits that have not yet posted to the account.
    /// Note that not all institutions calculate the Available Balance. In the case that Available
    /// Balance is unavailable from the institution, Plaid will either return an Available Balance
    /// value of null or only return a Current Balance.
    /// </remarks>
    [JsonObject]
    public class Balance
    {
        /// <summary>
        /// Gets or sets the available balance.
        /// </summary>
        /// <value>The available balance.</value>
        [JsonProperty("available")]
        public float Available { get; set; }

        /// <summary>
        /// Gets or sets the current balance.
        /// </summary>
        /// <value>The current balance.</value>
        [JsonProperty("current")]
        public float Current { get; set; }
    }
}