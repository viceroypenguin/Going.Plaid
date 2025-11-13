namespace Going.Plaid.Entity;

/// <summary>
/// <para>A Protect report associated with a user. Contains details about documented incidents, which may include fraud, investigation outcomes, or other risk events.</para>
/// </summary>
public record ProtectReport
{
	/// <summary>
	/// <para>A unique identifier representing the submitted report.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>Details about the incident event.</para>
	/// </summary>
	[JsonPropertyName("incident_event")]
	public Entity.ProtectIncidentEventResponse? IncidentEvent { get; init; } = default!;

	/// <summary>
	/// <para>The confidence level of the incident report.</para>
	/// </summary>
	[JsonPropertyName("report_confidence")]
	public Entity.ProtectReportConfidence ReportConfidence { get; init; } = default!;

	/// <summary>
	/// <para>The type of incident being reported.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.ProtectReportType ReportType { get; init; } = default!;

	/// <summary>
	/// <para>The source that identified or reported the incident.</para>
	/// </summary>
	[JsonPropertyName("report_source")]
	public Entity.ProtectReportSource ReportSource { get; init; } = default!;

	/// <summary>
	/// <para>Bank account information associated with the incident.</para>
	/// </summary>
	[JsonPropertyName("bank_account")]
	public Entity.ProtectBankAccount? BankAccount { get; init; } = default!;

	/// <summary>
	/// <para>ACH return code if the report type is <c>ACH_RETURN</c> (e.g. <c>R01</c>).</para>
	/// </summary>
	[JsonPropertyName("ach_return_code")]
	public string? AchReturnCode { get; init; } = default!;

	/// <summary>
	/// <para>Additional context or details about the report.</para>
	/// </summary>
	[JsonPropertyName("notes")]
	public string? Notes { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp when the report was created, in ISO 8601 format (e.g., '2020-07-24T03:26:02Z').</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

}
