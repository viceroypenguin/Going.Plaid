namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditBankIncomeWebhookUpdateRequest defines the request schema for <c>/credit/bank_income/webhook/update</c>.</para>
/// </summary>
public partial class CreditBankIncomeWebhookUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>Whether the user should be enabled for proactive webhook notifications when their income changes</para>
	/// </summary>
	[JsonPropertyName("enable_webhooks")]
	public bool EnableWebhooks { get; set; } = default!;

}
