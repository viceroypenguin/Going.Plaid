namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditBankIncomeWebhookUpdateRequest defines the request schema for <c>/credit/bank_income/webhook/update</c>.</para>
/// </summary>
public partial class CreditBankIncomeWebhookUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the user for which data is being requested. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>Whether the user should be enabled for proactive webhook notifications when their income changes</para>
	/// </summary>
	[JsonPropertyName("enable_webhooks")]
	public bool EnableWebhooks { get; set; } = default!;

}
