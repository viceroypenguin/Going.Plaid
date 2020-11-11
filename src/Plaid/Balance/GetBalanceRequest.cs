using System.Text.Json.Serialization;
using Going.Plaid.Options;

namespace Going.Plaid.Balance
{
	/// <summary>
	/// Represents a request for plaid's '<c>/accounts/balance/get</c>' endpoint. The POST <c>/accounts/balance/get</c> endpoint returns the real-time balance for each of an Item’s accounts. It can be used for existing Items that were added via any of Plaid’s other products.
	/// </summary>
	/// <remarks>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of <c>null</c>.</remarks>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class GetBalanceRequest : RequestBase
	{
		/// <summary>
		/// Optional filters for the request
		/// </summary>
		[JsonPropertyName("options")]
		public AccountOptions? Options { get; set; }
	}
}
