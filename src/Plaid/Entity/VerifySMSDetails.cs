namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional information for the <c>verify_sms</c> step.</para>
/// </summary>
public record VerifySMSDetails
{
	/// <summary>
	/// <para>The outcome status for the associated Identity Verification attempt's <c>verify_sms</c> step. This field will always have the same value as <c>steps.verify_sms</c>.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.VerifySMSDetailsStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>An array where each entry represents a verification attempt for the <c>verify_sms</c> step. Each entry represents one user-submitted phone number. Phone number edits, and in some cases error handling due to edge cases like rate limiting, may generate additional verifications.</para>
	/// </summary>
	[JsonPropertyName("verifications")]
	public IReadOnlyList<Entity.SMSVerification> Verifications { get; init; } = default!;

}
