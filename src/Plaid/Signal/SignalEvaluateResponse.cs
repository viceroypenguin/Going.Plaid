namespace Going.Plaid.Signal;

/// <summary>
/// <para>SignalEvaluateResponse defines the response schema for <c>/signal/income/evaluate</c></para>
/// </summary>
public record SignalEvaluateResponse : ResponseBase
{
	/// <summary>
	/// <para>Risk scoring details broken down by risk category.</para>
	/// </summary>
	[JsonPropertyName("scores")]
	public Entity.SignalEvaluateScores Scores { get; init; } = default!;

	/// <summary>
	/// <para>The core attributes object contains additional data that can be used to assess the ACH return risk, such as past ACH return events, balance/transaction history, the Item’s connection history in the Plaid network, and identity change history.</para>
	/// </summary>
	[JsonPropertyName("core_attributes")]
	public Entity.SignalEvaluateCoreAttributes CoreAttributes { get; init; } = default!;
}