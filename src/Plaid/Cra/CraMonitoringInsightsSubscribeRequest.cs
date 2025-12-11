namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsSubscribeRequest defines the request schema for <c>/cra/monitoring_insights/subscribe</c></para>
/// </summary>
public partial class CraMonitoringInsightsSubscribeRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>The item ID to subscribe for Cash Flow Updates.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; set; } = default!;

	/// <summary>
	/// <para>URL to which Plaid will send Cash Flow Updates webhooks, for example when the requested Cash Flow Updates report is ready.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// <para>Income categories to include in Cash Flow Updates. If empty or <c>null</c>, this field will default to including all possible categories.</para>
	/// </summary>
	[JsonPropertyName("income_categories")]
	public IReadOnlyList<Entity.CreditBankIncomeCategory>? IncomeCategories { get; set; } = default!;

	/// <summary>
	/// <para>The user token associated with the User data is being requested for. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

}
