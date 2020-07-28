using Going.Plaid.Entity;
using Newtonsoft.Json;

namespace Going.Plaid.Balance
{
	/// <summary>
	/// Represents a response from plaid's '<c>/accounts/balance/get</c>' endpoint. The POST <c>/accounts/balance/get</c> endpoint returns the real-time balance for each of an Item’s accounts. It can be used for existing Items that were added via any of Plaid’s other products.
	/// </summary>
	/// <remarks>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of <c>null</c>.</remarks>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class GetBalanceResponse : ResponseBase
	{
		/// <summary>
		/// The accounts with balance information included.
		/// </summary>
		[JsonProperty("accounts")]
		public Account[] Accounts { get; set; } = null!;

		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		[JsonProperty("item")]
		public Item Item { get; set; } = null!;
	}
}
