namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details regarding the proposed transfer.</para>
/// </summary>
public record TransferAuthorizationProposedTransfer
{
	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <a href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</a>.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass? AchClass { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the account that will be debited or credited.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The id of the associated funding account, available in the Plaid Dashboard. If present, this indicates which of your business checking accounts will be credited or debited.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string? FundingAccountId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a Plaid Ledger Balance.</para>
	/// </summary>
	[JsonPropertyName("ledger_id")]
	public string? LedgerId { get; init; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferType Type { get; init; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferUserInResponse User { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The network or rails used for the transfer.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public string Network { get; init; } = default!;

	/// <summary>
	/// <para>Information specific to wire transfers.</para>
	/// </summary>
	[JsonPropertyName("wire_details")]
	public Entity.TransferWireDetails? WireDetails { get; init; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for the origination account that was used for this transfer.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string OriginationAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the transfer amount. The default value is "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid client ID that is the originator of this transfer. Only present if created on behalf of another client as a <a href="https://plaid.com/docs/transfer/application/#originators-vs-platforms">Platform customer</a>.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; init; } = default!;

	/// <summary>
	/// <para>This field is now deprecated. You may ignore it for transfers created on and after 12/01/2023.</para>
	/// <para>Specifies the source of funds for the transfer. Only valid for <c>credit</c> transfers, and defaults to <c>sweep</c> if not specified. This field is not specified for <c>debit</c> transfers.</para>
	/// <para><c>sweep</c> - Sweep funds from your funding account</para>
	/// <para><c>prefunded_rtp_credits</c> - Use your prefunded RTP credit balance with Plaid</para>
	/// <para><c>prefunded_ach_credits</c> - Use your prefunded ACH credit balance with Plaid</para>
	/// </summary>
	[JsonPropertyName("credit_funds_source")]
	public Entity.TransferCreditFundsSource? CreditFundsSource { get; init; } = default!;

}
