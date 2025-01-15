namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the image quality of the document.</para>
/// </summary>
public record ImageQualityDetails
{
	/// <summary>
	/// <para>The outcome of the image quality check.</para>
	/// </summary>
	[JsonPropertyName("glare_check")]
	public Entity.ImageQualityOutcome GlareCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the image quality check.</para>
	/// </summary>
	[JsonPropertyName("dimensions_check")]
	public Entity.ImageQualityOutcome DimensionsCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the image quality check.</para>
	/// </summary>
	[JsonPropertyName("blur_check")]
	public Entity.ImageQualityOutcome BlurCheck { get; init; } = default!;

}
