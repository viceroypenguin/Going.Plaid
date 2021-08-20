namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>sandbox/oauth/select_accounts</c></para>
/// </summary>
public class SandboxOauthSelectAccountsRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("oauth_state_id")]
	public string OauthStateId { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<string> Accounts { get; set; } = default!;
}