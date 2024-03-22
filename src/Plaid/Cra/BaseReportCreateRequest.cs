namespace Going.Plaid.Cra;

/// <summary>
/// <para>BaseReportCreateRequest defines the request schema for <c>/cra/base_report/create</c></para>
/// </summary>
public partial class BaseReportCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The duration of transaction history you requested</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>URL to which Plaid will send Assets webhooks, for example when the requested Asset Report is ready.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>This enum describes the reason a consumer report is created for</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

}
