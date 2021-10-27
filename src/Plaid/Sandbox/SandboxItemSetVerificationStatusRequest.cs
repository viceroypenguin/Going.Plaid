namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxItemSetVerificationStatusRequest defines the request schema for <c>/sandbox/item/set_verification_status</c></para>
/// </summary>
public partial class SandboxItemSetVerificationStatusRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>account_id</c> of the account whose verification status is to be modified</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>The verification status to set the account to.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.SandboxItemSetVerificationStatusRequestVerificationStatusEnum VerificationStatus { get; set; } = default!;
}