using Going.Plaid.Entity;
using Newtonsoft.Json;

namespace Going.Plaid.Investments
{
    /// <summary>
    /// Represents a response from plaid's '/investments/transactions/get' endpoint. The /investments/transactions/get endpoint allows developers to retrieve user-authorized transaction data for investment accounts. Transaction data is standardized across financial institutions, and InvestmentTransactions are related to Securities, which are included in the response and conform to the Security schema.
    /// </summary>
    /// <remarks>Due to the potentially large number of transactions associated with an <see cref="Entity.Item"/>, results are paginated. Manipulate the count and offset parameters in conjunction with the total_transactions response body field to fetch all available Transactions.</remarks>
    /// <seealso cref="Going.Plaid.ResponseBase" />
    public class GetInvestmentTransactionsResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the total number of transactions in the time period. This is used to determine if pagination is needed
        /// </summary>
        /// <value>The total number of transactions in the time period.</value>
        [JsonProperty("total_investment_transactions")]
        public int TotalInvestmentTransactions { get; set; }

        /// <summary>
        /// Gets or sets the transactions.
        /// </summary>
        /// <value>The transactions.</value>
        [JsonProperty("investment_transactions")]
        public InvestmentTransaction[] InvestmentTransactions { get; set; }

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