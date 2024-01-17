namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Autofill represents unverified customer information. This needs to be confirmed by the customer before using.</para>
/// </summary>
public record IdentityVerificationAutofillCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A status enum indicating whether autofill succeeded or failed.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.IdentityVerificationAutofillStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>User information that was autofilled. All this information should be confirmed by the user before using.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.IdentityVerificationAutofillUserData? User { get; init; } = default!;

}
