namespace Going.Plaid.Protect;

/// <summary>
/// <para>Request object for <c>/protect/cash_advance/decision/create</c>.</para>
/// </summary>
public partial class ProtectCashAdvanceDecisionCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Represents an end user for <c>/protect/compute</c> requests.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.ProtectUser User { get; set; } = default!;

	/// <summary>
	/// <para>Your unique identifier for a cash-advance. Provide when available. This should be the same id provided when recording a repayment.</para>
	/// </summary>
	[JsonPropertyName("client_advance_id")]
	public string? ClientAdvanceId { get; set; } = default!;

	/// <summary>
	/// <para>The time the decision was made, in ISO 8601 / RFC 3339 format (<c>YYYY-MM-DDTHH:mm:ssZ</c>).</para>
	/// </summary>
	[JsonPropertyName("decision_time")]
	public DateTimeOffset DecisionTime { get; set; } = default!;

	/// <summary>
	/// <para>The outcome of a cash-advance decision.</para>
	/// </summary>
	[JsonPropertyName("decision")]
	public Entity.CashAdvanceDecisionOutcome Decision { get; set; } = default!;

	/// <summary>
	/// <para>The details of a cash-advance associated with an approved cash-advance decision. Required when a cash-advance has been approved.</para>
	/// </summary>
	[JsonPropertyName("cash_advance")]
	public Entity.CashAdvanceDetails? CashAdvance { get; set; } = default!;

}
