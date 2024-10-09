namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analysis of the facial features of the selfie when compared to the face in the uploaded document, if one is present.</para>
/// </summary>
public record SelfieAnalysisFacialAnalysis
{
	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("left_eye")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome LeftEye { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("right_eye")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome RightEye { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("left_brow")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome LeftBrow { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("right_brow")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome RightBrow { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("forehead")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome Forehead { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("middle_forehead")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome MiddleForehead { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("nose")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome Nose { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("philtrum")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome Philtrum { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("mouth")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome Mouth { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("jaw")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome Jaw { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("left_cheek")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome LeftCheek { get; init; } = default!;

	/// <summary>
	/// <para>Outcome of the facial analysis for a specific facial feature.</para>
	/// </summary>
	[JsonPropertyName("right_cheek")]
	public Entity.SelfieAnalysisFacialAnalysisOutcome RightCheek { get; init; } = default!;

}
