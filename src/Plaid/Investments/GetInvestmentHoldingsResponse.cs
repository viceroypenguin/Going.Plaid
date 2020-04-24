using Acklann.Plaid.Entity;
using Newtonsoft.Json;

namespace Acklann.Plaid.Investments
{
    /// <summary>
    /// Represents a response from plaid's '/investments/holdings/get' endpoint. The '/investments/holdings/get' endpoint allows developers to receive user-authorized stock position data for investment-type Accounts. Holding data is standardized across financial institutions, and Holdings are linked to Securities.
    /// 
    /// Every /investments/holdings/get response will contain a list of Securities, providing definitions for all security_id references in the response.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class GetInvestmentHoldingsResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the holdings.
        /// </summary>
        /// <value>The holdings returned by the server.</value>
        [JsonProperty("holdings")]
        public Holding[] Holdings { get; set; }

        /// <summary>
        /// Gets or sets the securities.
        /// </summary>
        /// <value>The securities returned by the server.</value>
        [JsonProperty("securities")]
        public Security[] Securities { get; set; }

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        [JsonProperty("item")]
        public Item Item { get; set; }

        /// <summary>
        /// Gets or sets the accounts.
        /// </summary>
        /// <value>The accounts.</value>
        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }
    }
}