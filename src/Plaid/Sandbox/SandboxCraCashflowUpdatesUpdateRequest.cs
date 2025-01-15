namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxCraCashflowUpdatesUpdateRequest defines the request schema for <c>/sandbox/cashflow_updates/update</c></para>
/// </summary>
public partial class SandboxCraCashflowUpdatesUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}
