namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains the authorization decision for a proposed transfer.</para>
/// </summary>
public record TransferAuthorization
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer authorization.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The datetime representing when the authorization was created, in the format <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

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

	/// <summary>
	/// <para>Signal insights including scores and attributes.</para>
	/// </summary>
	[JsonPropertyName("signal_insights")]
	public Entity.SignalInsights? SignalInsights { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the transfer is guaranteed by Plaid (Guarantee customers only). This field will contain either <c>GUARANTEED</c> or <c>NOT_GUARANTEED</c> indicating whether Plaid will guarantee the transfer. If the transfer is not guaranteed, additional information will be provided in the <c>guarantee_decision_rationale</c> field. Refer to the <c>code</c> field in <c>guarantee_decision_rationale</c> for details.</para>
	/// </summary>
	[JsonPropertyName("guarantee_decision")]
	public Entity.TransferAuthorizationGuaranteeDecision? GuaranteeDecision { get; init; } = default!;

	/// <summary>
	/// <para>The rationale for Plaid's decision to not guarantee a transfer. Will be <c>null</c> unless <c>guarantee_decision</c> is <c>NOT_GUARANTEED</c>.</para>
	/// </summary>
	[JsonPropertyName("guarantee_decision_rationale")]
	public Entity.TransferAuthorizationGuaranteeDecisionRationale? GuaranteeDecisionRationale { get; init; } = default!;

	/// <summary>
	/// <para>Details regarding the proposed transfer.</para>
	/// </summary>
	[JsonPropertyName("proposed_transfer")]
	public Entity.TransferAuthorizationProposedTransfer ProposedTransfer { get; init; } = default!;
}