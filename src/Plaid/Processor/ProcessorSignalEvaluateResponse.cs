namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorSignalEvaluateResponse defines the response schema for <c>/processor/signal/evaluate</c></para>
/// </summary>
public record ProcessorSignalEvaluateResponse : ResponseBase
{
	/// <summary>
	/// <para>Risk scoring details broken down by risk category.</para>
	/// </summary>
	[JsonPropertyName("scores")]
	public Entity.SignalEvaluateScores Scores { get; init; } = default!;

	/// <summary>
	/// <para>The core attributes object contains additional data that can be used to assess the ACH return risk. Examples of data include:</para>
	/// <para><c>days_since_first_plaid_connection</c>: The number of days since the first time the Item was connected to an application via Plaid</para>
	/// <para><c>plaid_connections_count_7d</c>: The number of times the Item has been connected to applications via Plaid over the past 7 days</para>
	/// <para><c>plaid_connections_count_30d</c>: The number of times the Item has been connected to applications via Plaid over the past 30 days</para>
	/// <para><c>total_plaid_connections_count</c>: The number of times the Item has been connected to applications via Plaid</para>
	/// <para><c>is_savings_or_money_market_account</c>: Indicates whether the ACH transaction funding account is a savings/money market account</para>
	/// <para>For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact Sales or your Plaid account manager</para>
	/// </summary>
	[JsonPropertyName("core_attributes")]
	public Entity.SignalEvaluateCoreAttributes? CoreAttributes { get; init; } = default!;

	/// <summary>
	/// <para>Details about the transaction result after evaluated by the requested Ruleset. If a <c>ruleset_key</c> is not provided, this field will be omitted. This feature is currently in closed beta; to request access, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("ruleset")]
	public Entity.SignalEvaluateRuleset? Ruleset { get; init; } = default!;

	/// <summary>
	/// <para>If bank information was not available to be used in the Signal model, this array contains warnings describing why bank data is missing. If you want to receive an API error instead of Signal scores in the case of missing bank data, file a support ticket or contact your Plaid account manager.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.SignalWarning>? Warnings { get; init; } = default!;

}
