using System.Text.Json.Serialization;

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
		[JsonPropertyName("item")]
		public Entity.Item Item { get; init; } = null!;

		/// <summary>
		/// The accounts attached to the <see cref="Item"/>
		/// </summary>
		[JsonPropertyName("accounts")]
		public Entity.Account[] Accounts { get; init; } = null!;
	}
}
