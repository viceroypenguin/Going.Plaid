namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsSubscribeRequest defines the request schema for <c>/cra/monitoring_insights/subscribe</c></para>
/// </summary>
public partial class CraMonitoringInsightsSubscribeRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>URL to which Plaid will send Monitoring Insights webhooks, for example when the requested Monitoring Insights is ready.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// <para>Income categories to include in Cash Flow Updates. If empty or <c>null</c>, this field will default to including all possible categories.</para>
	/// </summary>
	[JsonPropertyName("income_categories")]
	public IReadOnlyList<Entity.CreditBankIncomeCategory>? IncomeCategories { get; set; } = default!;

}
