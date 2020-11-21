using System.Text.Json.Serialization;
using Going.Plaid.Options;

namespace Going.Plaid.Liabilities
{
	/// <summary>
	/// Represents a request for plaid's '<c>/liabilities/get</c>' endpoint. The '<c>/liabilities/get</c>' endpoint returns various details about an <see cref="Entity.Item"/> with loan or credit accounts. Liabilities is supported for US and Canada accounts only. Currently supported account types are account type credit with account subtype credit card or paypal, and account type loan with account subtype student or mortgage.
	/// 
	/// The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling <see cref="PlaidClient.FetchLiabilitiesAsync(GetLiabilitiesRequest)"/>.
	/// </summary>
	/// <remarks>
	/// Note: This request may take some time to complete if liabilities was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the additional data.
	/// </remarks>
	public class GetLiabilitiesRequest : RequestBase
	{
		/// <summary>
		/// Gets or sets the holdings options.
		/// </summary>
		[JsonPropertyName("options")]
		public AccountOptions? Options { get; set; }
	}
}
