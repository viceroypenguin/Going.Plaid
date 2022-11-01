namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxPaymentProfileResetLoginResponse defines the response schema for <c>/sandbox/payment_profile/reset_login</c></para>
/// </summary>
public record SandboxPaymentProfileResetLoginResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the call succeeded</para>
	/// </summary>
	[JsonPropertyName("reset_login")]
	public bool ResetLogin { get; init; } = default!;
}