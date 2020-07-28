namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a request for plaid's '<c>/item/public_token/exchange</c>' endpoint. Exchange a Link public_token for an API access_token.
	/// </summary>
	/// <seealso cref="Going.Plaid.SerializableContent" />
	public class ExchangeTokenRequest : RequestBase { }
}
