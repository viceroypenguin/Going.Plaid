namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/ledger/withdraw</c></para>
/// </summary>
public partial class TransferLedgerWithdrawRequest : RequestBase
{
	/// <summary>
	/// <para>Client ID of the customer that owns the Ledger balance. This is so Plaid knows which of your customers to payout or collect funds. Only applicable for Platform customers. Do not include if you’re paying out to yourself.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>The id of the funding account to use, available in the Plaid Dashboard. This determines which of your business checking accounts will be credited or debited. Defaults to the account configured during onboarding. You can find your list of <c>funding_account_id</c>s in the Accounts page of your Plaid Dashboard, under the "Account ID" column.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string? FundingAccountId { get; set; } = default!;

	/// <summary>
	/// <para>A positive amount of how much will be withdrawn from the ledger balance (decimal string with two digits of precision e.g. "5.50").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>The description of the deposit that will be passed to the receiving bank (up to 10 characters). Note that banks utilize this field differently, and may or may not show it on the bank statement.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; } = default!;

	/// <summary>
	/// <para>A unique key provided by the client, per unique ledger withdraw. Maximum of 50 characters.</para>
	/// <para>The API supports idempotency for safely retrying the request without accidentally performing the same operation twice. For example, if a request to create a ledger withdraw fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single withdraw is created.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string IdempotencyKey { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferNetwork Network { get; set; } = default!;
}