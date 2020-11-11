using Newtonsoft.Json;

namespace Going.Plaid.Balance
{
	/// <summary>
	/// Represents a response from plaid's '<c>/accounts/get</c>' endpoint.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record GetAccountResponse : ResponseBase
	{
		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		[JsonProperty("item")]
		public Entity.Item Item { get; init; } = null!;

		/// <summary>
		/// The accounts attached to the <see cref="Item"/>
		/// </summary>
		[JsonProperty("accounts")]
		public Entity.Account[] Accounts { get; init; } = null!;
	}
}
