using Acklann.Plaid.Entity;
using Newtonsoft.Json;

namespace Acklann.Plaid.Balance
{
    /// <summary>
    /// Represents a response from plaid's '/accounts/balance/get' endpoint. The POST /accounts/balance/get endpoint returns the real-time balance for each of an Item’s accounts. It can be used for existing Items that were added via any of Plaid’s other products.
    /// </summary>
    /// <remarks>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of <c>null</c>.</remarks>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class GetBalanceResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the accounts.
        /// </summary>
        /// <value>The accounts.</value>
        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        [JsonProperty("item")]
        public Item Item { get; set; }
    }
}