namespace Going.Plaid.Entity;

/// <summary>
/// <para>The predicted industry classification for the business, based on digital presence assessments.</para>
/// </summary>
public record BusinessIndustryPrediction
{
	/// <summary>
	/// <para>NAICS code for the predicted business industry.</para>
	/// </summary>
	[JsonPropertyName("code")]
	public int Code { get; init; } = default!;

	/// <summary>
	/// <para>The business industry classification of the predicted NAICS code.</para>
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; init; } = default!;

}
