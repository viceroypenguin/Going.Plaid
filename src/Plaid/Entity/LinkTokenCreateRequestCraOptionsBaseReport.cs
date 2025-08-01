namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Base Report product, specifically the <c>client_report_id</c>.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsBaseReport
{
	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link to create reports that can be shared with GSEs for mortgage verification.</para>
	/// </summary>
	[JsonPropertyName("gse_options")]
	public Entity.LinkTokenCreateRequestCraOptionsBaseReportGSEOptions? GseOptions { get; set; } = default!;

	/// <summary>
	/// <para>Indicates that the report must include identity information. If identity information is not available, the report will fail.</para>
	/// </summary>
	[JsonPropertyName("require_identity")]
	public bool? RequireIdentity { get; set; } = default!;

}
