using Going.Plaid.Entity;
using Going.Plaid.Options;
using Newtonsoft.Json;

namespace Going.Plaid.Transactions
{
	/// <summary>
	/// Represents a response from plaid's '<c>/transactions/get</c>' endpoint. The <c>/transactions/get</c> endpoint allows developers to receive user-authorized transaction data for credit and depository-type Accounts. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
	/// </summary>
	/// <remarks>Due to the potentially large number of transactions associated with an <see cref="Entity.Item"/>, results are paginated. Manipulate the count and offset parameters in conjunction with the total_transactions response body field to fetch all available Transactions.</remarks>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record GetTransactionsResponse : ResponseBase
	{
		/// <summary>
		/// The total number of transactions that satisfy the request.
		/// </summary>
		/// <remarks>
		/// If this value is greater than the number of transactions in <see cref="Transactions"/>, 
		/// then re-issue the request with updated <see cref="PaginationOptions.Offset"/> value.
		/// </remarks>
		[JsonProperty("total_transactions")]
		public int TotalTransactions { get; init; }

		/// <summary>
		/// The transactions that match the request.
		/// </summary>
		[JsonProperty("transactions")]
		public Transaction[] Transactions { get; init; } = null!;

		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		[JsonProperty("item")]
		public Item Item { get; init; } = null!;

		/// <summary>
		/// The accounts about which information is requested.
		/// </summary>
		[JsonProperty("accounts")]
		public Account[] Accounts { get; init; } = null!;
	}
}
