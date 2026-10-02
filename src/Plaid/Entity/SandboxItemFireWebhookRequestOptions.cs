namespace Going.Plaid.Entity;

/// <summary>
/// <para>Values to set on the fired webhook's payload. Each field is named after the webhook field it sets. If specified, must not be <c>null</c>.</para>
/// </summary>
public class SandboxItemFireWebhookRequestOptions
{
	/// <summary>
	/// <para>The value to send as <c>new_transactions</c> in a <c>TRANSACTIONS</c> <c>DEFAULT_UPDATE</c> webhook. Defaults to 0. Only valid when <c>webhook_type</c> is <c>TRANSACTIONS</c> and <c>webhook_code</c> is <c>DEFAULT_UPDATE</c>.</para>
	/// </summary>
	[JsonPropertyName("new_transactions")]
	public int? NewTransactions { get; set; } = default!;

}
