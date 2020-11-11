using System.Text.Json.Serialization;
using Going.Plaid.Entity;
using Going.Plaid.Options;

namespace Going.Plaid.Investments
{
	/// <summary>
	/// Represents a response from plaid's '<c>/investments/transactions/get</c>' endpoint. The <c>/investments/transactions/get</c> endpoint allows developers to retrieve user-authorized transaction data for investment accounts. Transaction data is standardized across financial institutions, and InvestmentTransactions are related to Securities, which are included in the response and conform to the Security schema.
	/// </summary>
	/// <remarks>Due to the potentially large number of transactions associated with an <see cref="Entity.Item"/>, results are paginated. Manipulate the count and offset parameters in conjunction with the total_transactions response body field to fetch all available Transactions.</remarks>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record GetInvestmentTransactionsResponse : ResponseBase
	{
		/// <summary>
		/// The total number of transactions that satisfy the request.
		/// </summary>
		/// <remarks>
		/// If this value is greater than the number of transactions in <see cref="Transactions"/>, 
		/// then re-issue the request with updated <see cref="PaginationOptions.Offset"/> value.
		/// </remarks>
		[JsonPropertyName("total_investment_transactions")]
		public int TotalInvestmentTransactions { get; init; }

		/// <summary>
		/// Tthe transactions returned by the server.
		/// </summary>
		[JsonPropertyName("investment_transactions")]
		public InvestmentTransaction[] InvestmentTransactions { get; init; } = null!;

		/// <summary>
		/// The securities used in the transactions returned.
		/// </summary>
		[JsonPropertyName("securities")]
		public Security[] Securities { get; init; } = null!;

		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		[JsonPropertyName("item")]
		public Item Item { get; init; } = null!;

		/// <summary>
		/// The accounts attached to the <see cref="Item"/>
		/// </summary>
		[JsonPropertyName("accounts")]
		public Account[] Accounts { get; init; } = null!;
	}
}
