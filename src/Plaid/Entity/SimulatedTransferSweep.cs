namespace Going.Plaid.Entity;

/// <summary>
/// <para>A sweep returned from the <c>/sandbox/transfer/sweep/simulate</c> endpoint.</para>
/// <para>Can be null if there are no transfers to include in a sweep.</para>
/// </summary>
public record SimulatedTransferSweep
{
	/// <summary>
	/// <para>Identifier of the sweep.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; init; } = default!;

	/// <summary>
	/// <para>The id of the funding account to use, available in the Plaid Dashboard. This determines which of your business checking accounts will be credited or debited.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string? FundingAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when the sweep occurred, in RFC 3339 format.</para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset? Created { get; init; } = default!;

	/// <summary>
	/// <para>Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. "-10.00")</para>
	/// <para>If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string? Amount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the sweep, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The date when the sweep settled, in the YYYY-MM-DD format.</para>
	/// </summary>
	[JsonPropertyName("settled")]
	public DateOnly? Settled { get; init; } = default!;

	/// <summary>
	/// <para>The status of a sweep transfer</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.SweepStatus? Status { get; init; } = default!;

	/// <summary>
	/// <para>The trigger of the sweep</para>
	/// </summary>
	[JsonPropertyName("trigger")]
	public Entity.SweepTrigger? Trigger { get; init; } = default!;

	/// <summary>
	/// <para>The description of the deposit that will be passed to the receiving bank (up to 10 characters). Note that banks utilize this field differently, and may or may not show it on the bank statement.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; init; } = default!;

	/// <summary>
	/// <para>The trace identifier for the transfer based on its network. This will only be set after the transfer has posted.</para>
	/// <para>For <c>ach</c> or <c>same-day-ach</c> transfers, this is the ACH trace number. Currently, the field will remain null for transfers on other rails.</para>
	/// </summary>
	[JsonPropertyName("network_trace_id")]
	public string? NetworkTraceId { get; init; } = default!;

}
