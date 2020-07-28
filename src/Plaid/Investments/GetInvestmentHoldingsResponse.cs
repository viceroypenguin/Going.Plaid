using Going.Plaid.Entity;
using Newtonsoft.Json;

namespace Going.Plaid.Investments
{
	/// <summary>
	/// Represents a response from plaid's '<c>/investments/holdings/get</c>' endpoint. The '<c>/investments/holdings/get</c>' endpoint allows developers to receive user-authorized stock position data for investment-type Accounts. Holding data is standardized across financial institutions, and Holdings are linked to Securities.
	/// 
	/// Every <c>/investments/holdings/get</c> response will contain a list of Securities, providing definitions for all security_id references in the response.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class GetInvestmentHoldingsResponse : ResponseBase
	{
		/// <summary>
		/// The holdings returned by the server.
		/// </summary>
		[JsonProperty("holdings")]
		public Holding[] Holdings { get; set; } = null!;

		/// <summary>
		/// The securities returned by the server.
		/// </summary>
		[JsonProperty("securities")]
		public Security[] Securities { get; set; } = null!;

		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		[JsonProperty("item")]
		public Item Item { get; set; } = null!;

		/// <summary>
		/// The acounts about which information is requested.
		/// </summary>
		[JsonProperty("accounts")]
		public Account[] Accounts { get; set; } = null!;
	}
}
