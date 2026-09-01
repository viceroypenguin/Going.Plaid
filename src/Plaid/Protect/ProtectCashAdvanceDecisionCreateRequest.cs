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
	/// <para>Your unique identifier for a cash-advance. Required when <c>is_taken</c> is <c>true</c>. This should be the same identifier provided when recording a repayment.</para>
	/// </summary>
	[JsonPropertyName("client_advance_id")]
	public string? ClientAdvanceId { get; set; } = default!;

	/// <summary>
	/// <para>Required when <c>is_taken</c> is <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("advance_type")]
	public Entity.CashAdvanceType? AdvanceType { get; set; } = default!;

	/// <summary>
	/// <para>The number of cash-advances a user has previously taken.</para>
	/// </summary>
	[JsonPropertyName("previous_advance_count")]
	public int? PreviousAdvanceCount { get; set; } = default!;

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
	/// <para>Whether the end user took the cash-advance. Required when <c>decision</c> is APPROVED. When <c>true</c>, <c>client_advance_id</c> and <c>cash_advance</c> are required.</para>
	/// </summary>
	[JsonPropertyName("is_taken")]
	public bool? IsTaken { get; set; } = default!;

	/// <summary>
	/// <para>The details of a cash-advance associated with the decision. Required when <c>is_taken</c> is <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("cash_advance")]
	public Entity.CashAdvanceInfo? CashAdvance { get; set; } = default!;

}
