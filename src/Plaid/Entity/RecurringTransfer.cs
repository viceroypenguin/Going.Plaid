namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a recurring transfer within the Transfers API.</para>
/// </summary>
public record RecurringTransfer
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a recurring transfer.</para>
	/// </summary>
	[JsonPropertyName("recurring_transfer_id")]
	public string RecurringTransferId { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when this transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c></para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>A date in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// <para>The next transfer origination date after bank holiday adjustment.</para>
	/// </summary>
	[JsonPropertyName("next_origination_date")]
	public DateOnly? NextOriginationDate { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; init; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferType Type { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The status of the recurring transfer.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.TransferRecurringStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <a href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</a>.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass? AchClass { get; init; } = default!;

	/// <summary>
	/// <para>Networks eligible for recurring transfers.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferRecurrinngNetwork Network { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for the origination account that was used for this transfer.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string OriginationAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The id of the funding account to use, available in the Plaid Dashboard. This determines which of your business checking accounts will be credited or debited.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string FundingAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the transfer amount, e.g. "USD"</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The description of the recurring transfer.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("transfer_ids")]
	public IReadOnlyList<string> TransferIds { get; init; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferUserInResponse User { get; init; } = default!;

	/// <summary>
	/// <para>The schedule that the recurring transfer will be executed on.</para>
	/// </summary>
	[JsonPropertyName("schedule")]
	public Entity.TransferRecurringSchedule Schedule { get; init; } = default!;

}
