namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data, images, analysis, and results from the <c>documentary_verification</c> step. This field will be <c>null</c> unless <c>steps.documentary_verification</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.</para>
/// </summary>
public record DocumentaryVerification
{
	/// <summary>
	/// <para>The outcome status for the associated Identity Verification attempt's <c>documentary_verification</c> step. This field will always have the same value as <c>steps.documentary_verification</c>.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; init; } = default!;

	/// <summary>
	/// <para>An array of documents submitted to the <c>documentary_verification</c> step. Each entry represents one user submission, where each submission will contain both a front and back image, or just a front image, depending on the document type.</para>
	/// <para>Note: Plaid will automatically let a user submit a new set of document images up to three times if we detect that a previous attempt might have failed due to user error. For example, if the first set of document images are blurry or obscured by glare, the user will be asked to capture their documents again, resulting in at least two separate entries within <c>documents</c>. If the overall <c>documentary_verification</c> is <c>failed</c>, the user has exhausted their retry attempts.</para>
	/// </summary>
	[JsonPropertyName("documents")]
	public IReadOnlyList<Entity.DocumentaryVerificationDocument> Documents { get; init; } = default!;

}
