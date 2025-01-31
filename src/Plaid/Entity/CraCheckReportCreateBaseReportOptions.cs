namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate a Base Report</para>
/// </summary>
public class CraCheckReportCreateBaseReportOptions
{
	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

}
