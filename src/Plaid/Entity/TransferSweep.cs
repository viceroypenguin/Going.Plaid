namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes a sweep of funds to / from the sweep account.</para>
/// <para>A sweep is associated with many sweep events (events of type <c>swept</c> or <c>return_swept</c>) which can be retrieved by invoking the <c>/transfer/event/list</c> endpoint with the corresponding <c>sweep_id</c>.</para>
/// <para><c>swept</c> events occur when the transfer amount is credited or debited from your sweep account, depending on the <c>type</c> of the transfer. <c>return_swept</c> events occur when a transfer is returned and Plaid undoes the credit or debit.</para>
/// <para>The total sum of the <c>swept</c> and <c>return_swept</c> events is equal to the <c>amount</c> of the sweep Plaid creates and matches the amount of the entry on your sweep account ledger.</para>
/// </summary>
public record TransferSweep
{
	/// <summary>
	/// <para>Identifier of the sweep.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The id of the funding account to use, available in the Plaid Dashboard. This determines which of your business checking accounts will be credited or debited.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string FundingAccountId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a Plaid Ledger Balance.</para>
	/// </summary>
	[JsonPropertyName("ledger_id")]
	public string? LedgerId { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when the sweep occurred, in RFC 3339 format.</para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. "-10.00")</para>
	/// <para>If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the sweep, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The date when the sweep settled, in the YYYY-MM-DD format.</para>
	/// </summary>
	[JsonPropertyName("settled")]
	public DateOnly? Settled { get; init; } = default!;

	/// <summary>
	/// <para>The expected date when funds from a ledger deposit will be made available and can be withdrawn from the associated ledger balance. Only applies to deposits. This will be of the form YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("expected_funds_available_date")]
	public DateOnly? ExpectedFundsAvailableDate { get; init; } = default!;

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
	/// <para>For <c>ach</c> or <c>same-day-ach</c> transfers, this is the ACH trace number.</para>
	/// <para>For <c>rtp</c> transfers, this is the Transaction Identification number.</para>
	/// <para>For <c>wire</c> transfers, this is the IMAD (Input Message Accountability Data) number.</para>
	/// </summary>
	[JsonPropertyName("network_trace_id")]
	public string? NetworkTraceId { get; init; } = default!;

	/// <summary>
	/// <para>The failure reason if the status for a sweep is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.SweepFailure? FailureReason { get; init; } = default!;

}
