namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/asset_report/refresh</c> results. If provided, cannot be <c>null</c>. If not specified, the <c>options</c> from the original call to <c>/asset_report/create</c> will be used.</para>
/// </summary>
public class AssetReportRefreshRequestOptions
{
	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>URL to which Plaid will send Assets webhooks, for example when the requested Asset Report is ready.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The <c>first_name</c>, <c>last_name</c>, and <c>ssn</c> fields are required if you would like the Report to be eligible for Fannie Mae’s Day 1 Certainty™ program.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.AssetReportUser? User { get; set; } = default!;

}
