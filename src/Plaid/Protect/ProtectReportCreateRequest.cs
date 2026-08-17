namespace Going.Plaid.Protect;

/// <summary>
/// <para>Request object for <c>/protect/report/create</c>.</para>
/// <para>You must provide either <c>user_id</c>, or an <c>incident_event</c> with at least one supported identifier: <c>link_session_id</c>, <c>idv_session_id</c>, <c>protect_event_id</c>, <c>signal_client_transaction_id</c>, or <c>access_token</c>. Context fields such as <c>internal_reference</c>, <c>time</c>, <c>amount</c>, and <c>bank_account</c> do not satisfy this identifier requirement.</para>
/// </summary>
public partial class ProtectReportCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid User ID associated with the report.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>Details about the incident event.</para>
	/// </summary>
	[JsonPropertyName("incident_event")]
	public Entity.ProtectIncidentEvent? IncidentEvent { get; set; } = default!;

	/// <summary>
	/// <para>The confidence level of the incident report.</para>
	/// </summary>
	[JsonPropertyName("report_confidence")]
	public Entity.ProtectReportConfidence ReportConfidence { get; set; } = default!;

	/// <summary>
	/// <para>The type of incident being reported.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.ProtectReportType ReportType { get; set; } = default!;

	/// <summary>
	/// <para>The source that identified or reported the incident.</para>
	/// </summary>
	[JsonPropertyName("report_source")]
	public Entity.ProtectReportSource ReportSource { get; set; } = default!;

	/// <summary>
	/// <para>Bank account information associated with the incident.</para>
	/// </summary>
	[JsonPropertyName("bank_account")]
	public Entity.ProtectBankAccount? BankAccount { get; set; } = default!;

	/// <summary>
	/// <para>Must be a valid ACH return code (e.g. <c>R01</c>), required if <c>report_type</c> is <c>ACH_RETURN</c>.</para>
	/// </summary>
	[JsonPropertyName("ach_return_code")]
	public string? AchReturnCode { get; set; } = default!;

	/// <summary>
	/// <para>Additional context or details about the report.</para>
	/// </summary>
	[JsonPropertyName("notes")]
	public string? Notes { get; set; } = default!;

}
