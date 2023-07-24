namespace Going.Plaid.Entity;

/// <summary>
/// <para>Signal insights including scores and attributes. This response is offered as an add-on to <c>/transfer/authorization/create</c>. To request access to these fields please contact your Plaid account manager.</para>
/// </summary>
public record SignalInsights
{
	/// <summary>
	/// <para>Risk scoring details broken down by risk category.</para>
	/// </summary>
	[JsonPropertyName("scores")]
	public Entity.SignalEvaluateScores? Scores { get; init; } = default!;

	/// <summary>
	/// <para>If bank information was not available to be used in the Signal model, this array contains warnings describing why bank data is missing. If you want to receive an API error instead of Signal scores in the case of missing bank data, file a support ticket or contact your Plaid account manager.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.SignalWarning>? Warnings { get; init; } = default!;
}