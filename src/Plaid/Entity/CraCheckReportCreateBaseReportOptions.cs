namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate a Base Report</para>
/// </summary>
public class CraCheckReportCreateBaseReportOptions
{
	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications. This field is deprecated. Use the <c>client_report_id</c> field at the top level of the request instead.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	[Obsolete]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for creating reports that can be shared with GSEs for mortgage verification.</para>
	/// </summary>
	[JsonPropertyName("gse_options")]
	public Entity.CraCheckReportGSEOptions? GseOptions { get; set; } = default!;

	/// <summary>
	/// <para>Indicates that the report must include identity information. If identity information is not available, the report will fail.</para>
	/// </summary>
	[JsonPropertyName("require_identity")]
	public bool? RequireIdentity { get; set; } = default!;

}
