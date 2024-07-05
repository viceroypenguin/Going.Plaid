namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportCreateRequest defines the request schema for <c>/cra/check_report/create</c>.</para>
/// </summary>
public partial class CraCheckReportCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which webhooks will be sent</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The number of days of data to request for the report</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>Products that will be retrieved in this report. This configuration will determine what data types to fetch from the user's financial institution. If omitted, the data types needed to support all products will be fetched.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraCheckReportProduct>? Products { get; set; } = default!;

	/// <summary>
	/// <para>This enum describes the reason you are generating a Consumer Report for this user.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

}
