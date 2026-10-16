namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional information for the <c>selfie_check</c> step. This field will be <c>null</c> unless <c>steps.selfie_check</c> has reached a terminal state of <c>success</c>, <c>failed</c>, <c>manually_approved</c>, or <c>manually_rejected</c>.</para>
/// </summary>
public record SelfieCheck
{
	/// <summary>
	/// <para>The outcome status for the associated Identity Verification attempt's <c>selfie_check</c> step. This field will be <c>success</c> if <c>steps.selfie_check</c> is <c>success</c> or <c>manually_approved</c>, and <c>failed</c> if <c>steps.selfie_check</c> is <c>failed</c> or <c>manually_rejected</c>.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.SelfieCheckStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>An array of selfies submitted to the <c>selfie_check</c> step. Each entry represents one user submission.</para>
	/// </summary>
	[JsonPropertyName("selfies")]
	public IReadOnlyList<Entity.SelfieCheckSelfie> Selfies { get; init; } = default!;

}
