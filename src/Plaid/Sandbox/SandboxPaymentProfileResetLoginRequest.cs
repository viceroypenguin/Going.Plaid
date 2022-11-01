namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxPaymentProfileResetLoginRequest defines the request schema for <c>/sandbox/payment_profile/reset_login</c></para>
/// </summary>
public partial class SandboxPaymentProfileResetLoginRequest : RequestBase
{
	/// <summary>
	/// <para>A payment profile token associated with the Payment Profile data that is being requested.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_token")]
	public string PaymentProfileToken { get; set; } = default!;
}