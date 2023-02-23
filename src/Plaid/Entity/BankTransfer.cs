namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a bank transfer within the Bank Transfers API.</para>
/// </summary>
public record BankTransfer
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a bank transfer.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass AchClass { get; init; } = default!;

	/// <summary>
	/// <para>The account ID that should be credited/debited for this bank transfer.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.BankTransferType Type { get; init; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.BankTransferUser User { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the bank transfer (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the transfer amount, e.g. "USD"</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The description of the transfer.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when this bank transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c></para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transfer.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.BankTransferStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The network or rails used for the transfer. Valid options are <c>ach</c>, <c>same-day-ach</c>, or <c>wire</c>.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.BankTransferNetwork Network { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, you can still cancel this bank transfer.</para>
	/// </summary>
	[JsonPropertyName("cancellable")]
	public bool Cancellable { get; init; } = default!;

	/// <summary>
	/// <para>The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.BankTransferFailure? FailureReason { get; init; } = default!;

	/// <summary>
	/// <para>A string containing the custom tag provided by the client in the create request. Will be null if not provided.</para>
	/// </summary>
	[JsonPropertyName("custom_tag")]
	public string? CustomTag { get; init; } = default!;

	/// <summary>
	/// <para>The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:</para>
	/// <para>The JSON values must be Strings (no nested JSON objects allowed)</para>
	/// <para>Only ASCII characters may be used</para>
	/// <para>Maximum of 50 key/value pairs</para>
	/// <para>Maximum key length of 40 characters</para>
	/// <para>Maximum value length of 500 characters</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public IReadOnlyDictionary<string, string>? Metadata { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for the origination account that was used for this transfer.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string OriginationAccountId { get; init; } = default!;

	/// <summary>
	/// <para>Indicates the direction of the transfer: <c>outbound</c> for API-initiated transfers, or <c>inbound</c> for payments received by the FBO account.</para>
	/// </summary>
	[JsonPropertyName("direction")]
	public Entity.BankTransferDirection? Direction { get; init; } = default!;
}