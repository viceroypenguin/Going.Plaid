namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the status of a deposit switch request has changed.</para>
/// </summary>
public record DepositSwitchStateUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.DepositSwitch;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.SwitchStateUpdate;

	/// <summary>
	/// <para>The state, or status, of the deposit switch.</para>
	/// <para><c>initialized</c>: The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.</para>
	/// <para><c>processing</c>: The deposit switch request has been submitted and is being processed.</para>
	/// <para><c>completed</c>: The user's employer has fulfilled and completed the deposit switch request.</para>
	/// <para><c>error</c>: There was an error processing the deposit switch request.</para>
	/// <para>For more information, see the <a href="https://plaid.com/docs/deposit-switch/reference#deposit_switchget">Deposit Switch API reference</a>.</para>
	/// </summary>
	[JsonPropertyName("state")]
	public string? State { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the deposit switch.</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_id")]
	public string? DepositSwitchId { get; init; } = default!;
}