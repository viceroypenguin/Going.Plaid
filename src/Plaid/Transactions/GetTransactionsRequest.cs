using System;
using Going.Plaid.Options;
using Newtonsoft.Json;

namespace Going.Plaid.Transactions
{
	/// <summary>
	/// Represents a request for plaid's '<c>/transactions/get</c>' endpoint. The '<c>/transactions/get</c>' endpoint allows developers to receive user-authorized transaction data for credit and depository-type Accounts. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
	/// </summary>
	/// <remarks>Due to the potentially large number of transactions associated with an <see cref="Entity.Item"/>, results are paginated. Manipulate the count and offset parameters in conjunction with the total_transactions response body field to fetch all available Transactions.</remarks>
	public class GetTransactionsRequest : RequestBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetTransactionsRequest"/> class.
		/// </summary>
		public GetTransactionsRequest()
		{
			EndDate = DateTime.Now;
			StartDate = DateTime.Now.Subtract(TimeSpan.FromDays(30));
		}

		/// <summary>
		/// Gets or sets the start date.
		/// </summary>
		/// <value>The start date.</value>
		[JsonProperty("start_date")]
		public DateTime StartDate { get; set; }

		/// <summary>
		/// Gets or sets the end date.
		/// </summary>
		/// <value>The end date.</value>
		[JsonProperty("end_date")]
		public DateTime EndDate { get; set; }

		/// <summary>
		/// Gets or sets the pagination options.
		/// </summary>
		/// <value>The pagination options.</value>
		[JsonProperty("options")]
		public PaginationOptions? Options { get; set; }
	}
}
