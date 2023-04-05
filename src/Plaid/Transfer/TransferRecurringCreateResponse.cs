namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/recurring/create</c></para>
/// </summary>
public record TransferRecurringCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a recurring transfer within the Transfers API.</para>
	/// </summary>
	[JsonPropertyName("recurring_transfer")]
	public Entity.RecurringTransfer? RecurringTransfer { get; init; } = default!;

	/// <summary>
	/// <para>A decision regarding the proposed transfer.</para>
	/// </summary>
	[JsonPropertyName("decision")]
	public Entity.TransferAuthorizationDecision Decision { get; init; } = default!;

	/// <summary>
	/// <para>The rationale for Plaid's decision regarding a proposed transfer. It is always set for <c>declined</c> decisions, and may or may not be null for <c>approved</c> decisions.</para>
	/// </summary>
	[JsonPropertyName("decision_rationale")]
	public Entity.TransferAuthorizationDecisionRationale? DecisionRationale { get; init; } = default!;
}