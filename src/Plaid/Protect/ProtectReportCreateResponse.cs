namespace Going.Plaid.Protect;

/// <summary>
/// <para>Response object for /protect/report/create</para>
/// </summary>
public record ProtectReportCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique identifier representing the submitted report.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

}
