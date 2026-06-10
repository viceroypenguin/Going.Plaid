namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the image quality of the document.</para>
/// </summary>
public record ImageQualityDetails
{
	/// <summary>
	/// <para>The outcome of the glare check.</para>
	/// <para><c>success</c> - The image is free of glare.</para>
	/// <para><c>failed</c> - The image contains glare that may obscure document details.</para>
	/// </summary>
	[JsonPropertyName("glare_check")]
	public Entity.ImageQualityOutcome GlareCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the dimensions check.</para>
	/// <para><c>success</c> - The image meets the minimum size and resolution requirements.</para>
	/// <para><c>failed</c> - The image does not meet the minimum size or resolution requirements.</para>
	/// </summary>
	[JsonPropertyName("dimensions_check")]
	public Entity.ImageQualityOutcome DimensionsCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the blur check.</para>
	/// <para><c>success</c> - The image is sufficiently sharp.</para>
	/// <para><c>failed</c> - The image is too blurry for analysis.</para>
	/// </summary>
	[JsonPropertyName("blur_check")]
	public Entity.ImageQualityOutcome BlurCheck { get; init; } = default!;

}
