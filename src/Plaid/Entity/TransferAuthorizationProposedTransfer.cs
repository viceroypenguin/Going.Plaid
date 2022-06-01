namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details regarding the proposed transfer.</para>
/// </summary>
public record TransferAuthorizationProposedTransfer
{
	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass AchClass { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the account that will be debited or credited.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

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
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The network or rails used for the transfer.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public string Network { get; init; } = default!;

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
}