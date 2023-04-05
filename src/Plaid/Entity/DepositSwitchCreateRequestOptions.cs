namespace Going.Plaid.Entity;

/// <summary>
/// <para>Options to configure the <c>/deposit_switch/create</c> request. If provided, cannot be <c>null</c>.</para>
/// </summary>
public class DepositSwitchCreateRequestOptions
{
	/// <summary>
	/// <para>The URL registered to receive webhooks when the status of a deposit switch request has changed.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>An array of access tokens corresponding to transaction items to use when attempting to match the user to their Payroll Provider. These tokens must be created by the same client id as the one creating the switch, and have access to the transactions product.</para>
	/// </summary>
	[JsonPropertyName("transaction_item_access_tokens")]
	public IReadOnlyList<string>? TransactionItemAccessTokens { get; set; } = default!;
}