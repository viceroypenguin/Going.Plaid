namespace Going.Plaid.Entity;

/// <summary>
/// <para>Catpures and analysis from a user's selfie.</para>
/// </summary>
public record SelfieCheckSelfie
{
	/// <summary>
	/// <para>An outcome status for this specific selfie. Distinct from the overall <c>selfie_check.status</c> that summarizes the verification outcome from one or more selfies.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.SelfieStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The <c>attempt</c> field begins with 1 and increments with each subsequent selfie upload.</para>
	/// </summary>
	[JsonPropertyName("attempt")]
	public int Attempt { get; init; } = default!;

	/// <summary>
	/// <para>The image or video capture of a selfie. Only one of image or video URL will be populated per selfie.</para>
	/// </summary>
	[JsonPropertyName("capture")]
	public Entity.SelfieCapture Capture { get; init; } = default!;

	/// <summary>
	/// <para>High level descriptions of how the associated selfie was processed. If a seflfie fails verification, the details in the <c>analysis</c> object should help clarify why the selfie was rejected.</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.SelfieAnalysis Analysis { get; init; } = default!;
}