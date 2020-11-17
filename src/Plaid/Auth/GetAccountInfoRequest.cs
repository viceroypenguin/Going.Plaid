using System.Text.Json.Serialization;
using Going.Plaid.Options;

namespace Going.Plaid.Auth
{
	/// <summary>
	/// Represents a request for plaid's '<c>/auth/get</c>' endpoint. The '<c>/auth/get</c>' endpoint allows you to retrieve the bank account and routing numbers associated with an <see cref="Entity.Item"/>’s checking and savings accounts, along with high-level account data and balances.
	/// </summary>
	/// <remarks>
	/// The Auth product performs two crucial functions. It translates bank access credentials (username and password) into an account and routing number. No input of account or routing number is necessary. It also validates the owner of this account number in a NACHA-compliant manner. This eliminates the need for micro-deposits or any other secondary authentication.
	/// </remarks>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class GetAccountInfoRequest : RequestBase
	{
		/// <summary>
		/// Optional filters for the request
		/// </summary>
		[JsonPropertyName("options")]
		public AccountOptions? Options { get; set; } = null!;
	}
}
