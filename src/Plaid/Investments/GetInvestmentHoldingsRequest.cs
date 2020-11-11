using System.Text.Json.Serialization;
using Going.Plaid.Options;

namespace Going.Plaid.Investments
{
	/// <summary>
	/// Represents a request for plaid's '<c>/investments/holdings/get</c>' endpoint. The '<c>/investments/holdings/get</c>' endpoint allows developers to receive user-authorized stock position data for investment-type Accounts. Holding data is standardized across financial institutions, and Holdings are linked to Securities.
	/// 
	/// Every <c>/investments/holdings/get</c> response will contain a list of Securities, providing definitions for all security_id references in the response.
	/// </summary>
	public class GetInvestmentHoldingsRequest : RequestBase
	{
		/// <summary>
		/// Gets or sets the holdings options.
		/// </summary>
		[JsonPropertyName("options")]
		public AccountOptions? Options { get; set; }
	}
}
