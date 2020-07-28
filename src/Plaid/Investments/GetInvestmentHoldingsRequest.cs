using Newtonsoft.Json;
using System;

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
		[JsonProperty("options")]
		public HoldingsOptions? Options { get; set; }

		/// <summary>
		/// Represents holdings options.
		/// </summary>
		public class HoldingsOptions
		{
			/// <summary>
			/// The list of account ids to retrieve for the <see cref="Entity.Item" />.
			/// </summary>
			/// <remarks>An error will be returned if a provided account_id is not associated with the <see cref="Entity.Item" />.</remarks>
			[JsonProperty("account_ids")]
			public string[] AccountIds { get; set; } = Array.Empty<string>();
		}
	}
}
