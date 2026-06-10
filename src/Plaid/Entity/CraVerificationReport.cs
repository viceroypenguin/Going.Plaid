namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA Home Lending Report.</para>
/// </summary>
public record CraVerificationReport
{
	/// <summary>
	/// <para>The unique identifier associated with the Home Lending Report object. This ID will be the same as the Base Report ID.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>A unique token that can be shared with GSEs in order to provide them access to the report. This is automatically created during report generation when GSE options are specified.</para>
	/// </summary>
	[JsonPropertyName("gse_reference_id")]
	public string? GseReferenceId { get; init; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a VOA report.</para>
	/// </summary>
	[JsonPropertyName("voa")]
	public Entity.CraVoaReport? Voa { get; init; } = default!;

	/// <summary>
	/// <para>An object representing an Employment Refresh Report.</para>
	/// </summary>
	[JsonPropertyName("employment_refresh")]
	public Entity.CraEmploymentRefreshReport? EmploymentRefresh { get; init; } = default!;

	/// <summary>
	/// <para>An object representing an Income Report within the Home Lending Report.</para>
	/// </summary>
	[JsonPropertyName("income")]
	public Entity.CraVerificationIncomeReport? Income { get; init; } = default!;

}
