namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a transfer within the Transfers API.</para>
/// </summary>
public record Transfer
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer authorization.</para>
	/// </summary>
	[JsonPropertyName("authorization_id")]
	public string AuthorizationId { get; init; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <a href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</a>.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass? AchClass { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.</para>
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
	/// <para>The description of the transfer.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when this transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c></para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transfer.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.TransferStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The status of the sweep for the transfer.</para>
	/// </summary>
	[JsonPropertyName("sweep_status")]
	public Entity.TransferSweepStatus? SweepStatus { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferNetwork Network { get; init; } = default!;

	/// <summary>
	/// <para>Information specific to wire transfers.</para>
	/// </summary>
	[JsonPropertyName("wire_details")]
	public Entity.TransferWireDetails? WireDetails { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, you can still cancel this transfer.</para>
	/// </summary>
	[JsonPropertyName("cancellable")]
	public bool Cancellable { get; init; } = default!;

	/// <summary>
	/// <para>The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferFailure? FailureReason { get; init; } = default!;

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
	[Obsolete]
	public string OriginationAccountId { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the transfer is guaranteed by Plaid (Guarantee customers only). This field will contain either <c>GUARANTEED</c> or <c>NOT_GUARANTEED</c> indicating whether Plaid will guarantee the transfer. If the transfer is not guaranteed, additional information will be provided in the <c>guarantee_decision_rationale</c> field. Refer to the <c>code</c> field in <c>guarantee_decision_rationale</c> for details.</para>
	/// </summary>
	[JsonPropertyName("guarantee_decision")]
	public Entity.TransferAuthorizationGuaranteeDecision? GuaranteeDecision { get; init; } = default!;

	/// <summary>
	/// <para>The rationale for Plaid's decision to not guarantee a transfer. Will be <c>null</c> unless <c>guarantee_decision</c> is <c>NOT_GUARANTEED</c>.</para>
	/// </summary>
	[JsonPropertyName("guarantee_decision_rationale")]
	public Entity.TransferAuthorizationGuaranteeDecisionRationale? GuaranteeDecisionRationale { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the transfer amount, e.g. "USD"</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The date 3 business days from settlement date indicating the following ACH returns can no longer happen: R01, R02, R03, R29. This will be of the form YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("standard_return_window")]
	public DateOnly? StandardReturnWindow { get; init; } = default!;

	/// <summary>
	/// <para>The date 61 business days from settlement date indicating the following ACH returns can no longer happen: R05, R07, R10, R11, R51, R33, R37, R38, R51, R52, R53. This will be of the form YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("unauthorized_return_window")]
	public DateOnly? UnauthorizedReturnWindow { get; init; } = default!;

	/// <summary>
	/// <para>The date when settlement will occur between Plaid and the receiving bank (RDFI). For ACH debits, this is the date funds will be pulled from the bank account being debited. For ACH credits, this is the date funds will be delivered to the bank account being credited. Only set for ACH transfers; <c>null</c> for non-ACH transfers. This will be of the form YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("expected_settlement_date")]
	public DateOnly? ExpectedSettlementDate { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid client ID that is the originator of this transfer. Only present if created on behalf of another client as a <a href="https://plaid.com/docs/transfer/application/#originators-vs-platforms">Platform customer</a>.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; init; } = default!;

	/// <summary>
	/// <para>A list of refunds associated with this transfer.</para>
	/// </summary>
	[JsonPropertyName("refunds")]
	public IReadOnlyList<Entity.TransferRefund> Refunds { get; init; } = default!;

	/// <summary>
	/// <para>The id of the recurring transfer if this transfer belongs to a recurring transfer.</para>
	/// </summary>
	[JsonPropertyName("recurring_transfer_id")]
	public string? RecurringTransferId { get; init; } = default!;

	/// <summary>
	/// <para>The expected sweep settlement schedule of this transfer, assuming this transfer is not <c>returned</c>. Only applies to ACH debit transfers.</para>
	/// </summary>
	[JsonPropertyName("expected_sweep_settlement_schedule")]
	public IReadOnlyList<Entity.TransferExpectedSweepSettlementScheduleItem>? ExpectedSweepSettlementSchedule { get; init; } = default!;

	/// <summary>
	/// <para>This field is now deprecated. You may ignore it for transfers created on and after 12/01/2023.</para>
	/// <para>Specifies the source of funds for the transfer. Only valid for <c>credit</c> transfers, and defaults to <c>sweep</c> if not specified. This field is not specified for <c>debit</c> transfers.</para>
	/// <para><c>sweep</c> - Sweep funds from your funding account</para>
	/// <para><c>prefunded_rtp_credits</c> - Use your prefunded RTP credit balance with Plaid</para>
	/// <para><c>prefunded_ach_credits</c> - Use your prefunded ACH credit balance with Plaid</para>
	/// </summary>
	[JsonPropertyName("credit_funds_source")]
	[Obsolete]
	public Entity.TransferCreditFundsSource? CreditFundsSource { get; init; } = default!;

	/// <summary>
	/// <para>The amount to deduct from <c>transfer.amount</c> and distribute to the platform’s Ledger balance as a facilitator fee (decimal string with two digits of precision e.g. "10.00"). The remainder will go to the end-customer’s Ledger balance. This must be less than or equal to the <c>transfer.amount</c>.</para>
	/// </summary>
	[JsonPropertyName("facilitator_fee")]
	public string? FacilitatorFee { get; init; } = default!;

	/// <summary>
	/// <para>The trace identifier for the transfer based on its network. This will only be set after the transfer has posted.</para>
	/// <para>For <c>ach</c> or <c>same-day-ach</c> transfers, this is the ACH trace number.</para>
	/// <para>For <c>rtp</c> transfers, this is the Transaction Identification number.</para>
	/// <para>For <c>wire</c> transfers, this is the IMAD (Input Message Accountability Data) number.</para>
	/// </summary>
	[JsonPropertyName("network_trace_id")]
	public string? NetworkTraceId { get; init; } = default!;

}
