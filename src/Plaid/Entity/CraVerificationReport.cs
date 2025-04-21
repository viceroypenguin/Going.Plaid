namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA Verification Report.</para>
/// </summary>
public record CraVerificationReport
{
	/// <summary>
	/// <para>The unique identifier associated with the Verification Report object. This ID will be the same as the Base Report ID.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a VOE report.</para>
	/// </summary>
	[JsonPropertyName("voa")]
	public Entity.CraVoaReport? Voa { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a VOE report.</para>
	/// </summary>
	[JsonPropertyName("voe")]
	public Entity.CraVoeReport? Voe { get; init; } = default!;

}
