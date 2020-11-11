using System.Text.Json.Serialization;
using Going.Plaid.Entity;

namespace Going.Plaid.Balance
{
	/// <summary>
	/// Represents a response from plaid's '<c>/accounts/balance/get</c>' endpoint. The POST <c>/accounts/balance/get</c> endpoint returns the real-time balance for each of an Item’s accounts. It can be used for existing Items that were added via any of Plaid’s other products.
	/// </summary>
	/// <remarks>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of <c>null</c>.</remarks>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record GetBalanceResponse : ResponseBase
	{
		/// <summary>
		/// The accounts with balance information included.
		/// </summary>
		[JsonPropertyName("accounts")]
		public Account[] Accounts { get; init; } = null!;

		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		[JsonPropertyName("item")]
		public Item Item { get; init; } = null!;
	}
}
