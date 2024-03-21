namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraBankIncomeCreateRequest defines the request schema for <c>/cra/bank_income/create</c>.</para>
/// </summary>
public partial class CraBankIncomeCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which webhooks will be sent</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The number of days of data to request for the Bank Income product</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>This enum describes the reason a consumer report is created for</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose? ConsumerReportPermissiblePurpose { get; set; } = default!;

}
