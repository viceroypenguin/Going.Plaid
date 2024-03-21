namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Base Report product. This field is required if <c>assets</c> is included in the <c>products</c> array and the client is CRA-enabled.</para>
/// </summary>
public class LinkTokenCreateRequestBaseReport
{
	/// <summary>
	/// <para>The maximum integer number of days of history to include in the Base Report.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

}
