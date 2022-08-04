namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditRelayRemoveRequest defines the request schema for <c>/credit/relay/remove</c></para>
/// </summary>
public partial class CreditRelayRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>relay_token</c> you would like to revoke.</para>
	/// </summary>
	[JsonPropertyName("relay_token")]
	public string RelayToken { get; set; } = default!;
}