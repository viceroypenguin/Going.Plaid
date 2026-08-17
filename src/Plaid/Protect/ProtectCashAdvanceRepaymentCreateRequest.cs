namespace Going.Plaid.Protect;

/// <summary>
/// <para>Request object for <c>/protect/cash_advance/repayment/create</c>.</para>
/// </summary>
public partial class ProtectCashAdvanceRepaymentCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Represents an end user for <c>/protect/compute</c> requests.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.ProtectUser User { get; set; } = default!;

	/// <summary>
	/// <para>The client's unique identifier for the cash-advance.</para>
	/// </summary>
	[JsonPropertyName("client_advance_id")]
	public string ClientAdvanceId { get; set; } = default!;

	/// <summary>
	/// <para>The repayment status of a cash-advance.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.CashAdvanceRepaymentStatus Status { get; set; } = default!;

	/// <summary>
	/// <para>The time the repayment occurred, in ISO 8601 / RFC 3339 format (<c>YYYY-MM-DDTHH:mm:ssZ</c>).</para>
	/// </summary>
	[JsonPropertyName("repayment_time")]
	public DateTimeOffset? RepaymentTime { get; set; } = default!;

	/// <summary>
	/// <para>The repayment details for a cash-advance.</para>
	/// </summary>
	[JsonPropertyName("repayment")]
	public Entity.CashAdvanceRepayment Repayment { get; set; } = default!;

}
