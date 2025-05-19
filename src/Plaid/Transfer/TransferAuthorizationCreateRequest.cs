namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/authorization/create</c></para>
/// </summary>
public partial class TransferAuthorizationCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>Specify the account used to fund the transfer. Should be specified if using legacy funding methods only. If using Plaid Ledger, leave this field blank. Customers can find a list of <c>funding_account_id</c>s in the Accounts page of your Plaid Dashboard, under the "Account ID" column. If this field is left blank and you are using legacy funding methods, this will default to the default <c>funding_account_id</c> specified during onboarding. Otherwise, Plaid Ledger will be used.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string? FundingAccountId { get; set; } = default!;

	/// <summary>
	/// <para>Specify which ledger balance should be used to fund the transfer. You can find a list of <c>ledger_id</c>s in the Accounts page of your Plaid Dashboard. If this field is left blank, this will default to id of the default ledger balance.</para>
	/// </summary>
	[JsonPropertyName("ledger_id")]
	public string? LedgerId { get; set; } = default!;

	/// <summary>
	/// <para>The payment profile token associated with the Payment Profile that will be debited or credited. Required if not using <c>access_token</c>.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_token")]
	public string? PaymentProfileToken { get; set; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferType Type { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferNetwork Network { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <a href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</a>.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass? AchClass { get; set; } = default!;

	/// <summary>
	/// <para>Information specific to wire transfers.</para>
	/// </summary>
	[JsonPropertyName("wire_details")]
	public Entity.TransferWireDetails? WireDetails { get; set; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.  If the account has multiple account holders, provide the information for the account holder on whose behalf the authorization is being requested. The <c>user.legal_name</c> field is required. Other fields are not currently used and are present to support planned future functionality.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferAuthorizationUserInRequest User { get; set; } = default!;

	/// <summary>
	/// <para>Information about the device being used to initiate the authorization. These fields are not currently incorporated into the risk check.</para>
	/// </summary>
	[JsonPropertyName("device")]
	public Entity.TransferAuthorizationDevice? Device { get; set; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for the origination account for this authorization. If not specified, the default account will be used.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	[Obsolete]
	public string? OriginationAccountId { get; set; } = default!;

	/// <summary>
	/// <para>The currency of the transfer amount. The default value is "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>A random key provided by the client, per unique authorization, which expires after 48 hours. Maximum of 50 characters.</para>
	/// <para>The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create an authorization fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single authorization is created.</para>
	/// <para>Idempotency does not apply to authorizations whose decisions are <c>user_action_required</c>. Therefore you may re-attempt the authorization after completing the required user action without changing <c>idempotency_key</c>.</para>
	/// <para>This idempotency key expires after 48 hours, after which the same key can be reused. Failure to provide this key may result in duplicate charges.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string? IdempotencyKey { get; set; } = default!;

	/// <summary>
	/// <para>If the end user is initiating the specific transfer themselves via an interactive UI, this should be <c>true</c>; for automatic recurring payments where the end user is not actually initiating each individual transfer, it should be <c>false</c>. This field is not currently used and is present to support planned future functionality.</para>
	/// </summary>
	[JsonPropertyName("user_present")]
	public bool? UserPresent { get; set; } = default!;

	/// <summary>
	/// <para>If set to <c>false</c>, Plaid will not offer a <c>guarantee_decision</c> for this request (Guarantee customers only).</para>
	/// </summary>
	[JsonPropertyName("with_guarantee")]
	public bool? WithGuarantee { get; set; } = default!;

	/// <summary>
	/// <para>The unique identifier returned by Plaid's <a href="https://plaid.com/docs/transfer/guarantee/#using-a-beacon">beacon</a> when it is run on your webpage.</para>
	/// </summary>
	[JsonPropertyName("beacon_session_id")]
	public string? BeaconSessionId { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid client ID that is the originator of this transfer. Only needed if creating transfers on behalf of another client as a <a href="https://plaid.com/docs/transfer/application/#originators-vs-platforms">Platform customer</a>.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>This field is now deprecated. You may ignore it for transfers created on and after 12/01/2023.</para>
	/// <para>Specifies the source of funds for the transfer. Only valid for <c>credit</c> transfers, and defaults to <c>sweep</c> if not specified. This field is not specified for <c>debit</c> transfers.</para>
	/// <para><c>sweep</c> - Sweep funds from your funding account</para>
	/// <para><c>prefunded_rtp_credits</c> - Use your prefunded RTP credit balance with Plaid</para>
	/// <para><c>prefunded_ach_credits</c> - Use your prefunded ACH credit balance with Plaid</para>
	/// </summary>
	[JsonPropertyName("credit_funds_source")]
	[Obsolete]
	public Entity.TransferCreditFundsSource? CreditFundsSource { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock. This field may only be used when using <c>sandbox</c> environment. If provided, the <c>authorization</c> is created at the <c>virtual_time</c> on the provided test clock.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; set; } = default!;

	/// <summary>
	/// <para>The key of the Ruleset for the transaction. This feature is currently in closed beta; to request access, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("ruleset_key")]
	public string? RulesetKey { get; set; } = default!;

}
