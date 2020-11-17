using System.Text.Json.Serialization;
using Going.Plaid.Entity;

namespace Going.Plaid.Investments
{
	/// <summary>
	/// Represents a response from plaid's '<c>/investments/holdings/get</c>' endpoint. The '<c>/investments/holdings/get</c>' endpoint allows developers to receive user-authorized stock position data for investment-type Accounts. Holding data is standardized across financial institutions, and Holdings are linked to Securities.
	/// 
	/// Every <c>/investments/holdings/get</c> response will contain a list of Securities, providing definitions for all security_id references in the response.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record GetInvestmentHoldingsResponse : ResponseBase
	{
		/// <summary>
		/// The holdings returned by the server.
		/// </summary>
		[JsonPropertyName("holdings")]
		public Holding[] Holdings { get; init; } = null!;

		/// <summary>
		/// The securities returned by the server.
		/// </summary>
		[JsonPropertyName("securities")]
		public Security[] Securities { get; init; } = null!;

		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		[JsonPropertyName("item")]
		public Item Item { get; init; } = null!;

		/// <summary>
		/// The acounts about which information is requested.
		/// </summary>
		[JsonPropertyName("accounts")]
		public Account[] Accounts { get; init; } = null!;
	}
}
