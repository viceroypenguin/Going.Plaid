namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxItemResetLoginResponse defines the response schema for <c>/sandbox/item/reset_login</c></para>
/// </summary>
public record SandboxItemResetLoginResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the call succeeded</para>
	/// </summary>
	[JsonPropertyName("reset_login")]
	public bool ResetLogin { get; init; } = default!;

}
