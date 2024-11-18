namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/create</c></para>
/// </summary>
public partial class TransferCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Deprecated. <c>authorization_id</c> is now used as idempotency instead.</para>
	/// <para>A random key provided by the client, per unique transfer. Maximum of 50 characters.</para>
	/// <para>The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single transfer is created.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string? IdempotencyKey { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer authorization. This parameter also serves the purpose of acting as an idempotency identifier.</para>
	/// </summary>
	[JsonPropertyName("authorization_id")]
	public string AuthorizationId { get; set; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferType? Type { get; set; } = default!;

	/// <summary>
	/// <para>The network or rails used for the transfer.</para>
	/// <para>For transfers submitted as <c>ach</c>, the next-day cutoff is 8:30 PM Eastern Time.</para>
	/// <para>For transfers submitted as <c>same-day-ach</c>, the same-day cutoff is 3:30 PM Eastern Time. If the transfer is submitted after this cutoff but before the next-day cutoff, it will be sent over next-day rails and will not incur same-day charges; this will apply to both legs of the transfer if applicable.</para>
	/// <para>For transfers submitted as <c>rtp</c>,  Plaid will automatically route between Real Time Payment rail by TCH or FedNow rails as necessary. If a transfer is submitted as <c>rtp</c> and the counterparty account is not eligible for RTP, the <c>/transfer/authorization/create</c> request will fail with an <c>INVALID_FIELD</c> error code. To pre-check to determine whether a counterparty account can support RTP, call <c>/transfer/capabilities/get</c> before calling <c>/transfer/authorization/create</c>.</para>
	/// <para>Wire transfers are currently in early availability. To request access to <c>wire</c> as a payment network, contact your Account Manager. For transfers submitted as <c>wire</c>, the <c>type</c> must be <c>credit</c>; wire debits are not supported.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferNetwork? Network { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string? Amount { get; set; } = default!;

	/// <summary>
	/// <para>The transfer description. Maximum of 15 characters. If reprocessing a returned transfer, please note that the <c>description</c> field must be <c>"Retry 1"</c> or <c>"Retry 2"</c> to indicate that it's a retry of a previously returned transfer. You may retry a transfer up to 2 times, within 180 days of creating the original transfer. Only transfers that were returned with code <c>R01</c> or <c>R09</c> may be retried. For a full listing of ACH return codes, see <a href="https://plaid.com/docs/errors/transfer/#ach-return-codes">Transfer errors</a>.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <a href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</a>.</para>
	/// <para>Codes supported for credits: <c>ccd</c>, <c>ppd</c></para>
	/// <para>Codes supported for debits: <c>ccd</c>, <c>tel</c>, <c>web</c></para>
	/// <para><c>"ccd"</c> - Corporate Credit or Debit - fund transfer between two corporate bank accounts</para>
	/// <para><c>"ppd"</c> - Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, e.g. bill payment</para>
	/// <para><c>"tel"</c> - Telephone-Initiated Entry</para>
	/// <para><c>"web"</c> - Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass? AchClass { get; set; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferUserInRequestDeprecated? User { get; set; } = default!;

	/// <summary>
	/// <para>The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:</para>
	/// <para>The JSON values must be Strings (no nested JSON objects allowed)</para>
	/// <para>Only ASCII characters may be used</para>
	/// <para>Maximum of 50 key/value pairs</para>
	/// <para>Maximum key length of 40 characters</para>
	/// <para>Maximum value length of 500 characters</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public IReadOnlyDictionary<string, string>? Metadata { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for the origination account for this transfer. If you have more than one origination account, this value must be specified. Otherwise, this field should be left blank.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;

	/// <summary>
	/// <para>The currency of the transfer amount. The default value is "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock. This field may only be used when using <c>sandbox</c> environment. If provided, the <c>transfer</c> is created at the <c>virtual_time</c> on the provided <c>test_clock</c>.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; set; } = default!;

	/// <summary>
	/// <para>The amount to deduct from <c>transfer.amount</c> and distribute to the platform’s Ledger balance as a facilitator fee (decimal string with two digits of precision e.g. "10.00"). The remainder will go to the end-customer’s Ledger balance. This must be less than or equal to the <c>transfer.amount</c>.</para>
	/// </summary>
	[JsonPropertyName("facilitator_fee")]
	public string? FacilitatorFee { get; set; } = default!;

}
