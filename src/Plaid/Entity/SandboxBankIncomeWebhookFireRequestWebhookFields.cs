namespace Going.Plaid.Entity;

/// <summary>
/// <para>Optional fields which will be populated in the simulated webhook</para>
/// </summary>
public class SandboxBankIncomeWebhookFireRequestWebhookFields
{
	/// <summary>
	/// <para>The user id to be returned in INCOME webhooks</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>The result of the bank income refresh report generation</para>
	/// </summary>
	[JsonPropertyName("bank_income_refresh_complete_result")]
	public Entity.BankIncomeRefreshCompleteResult? BankIncomeRefreshCompleteResult { get; set; } = default!;
}