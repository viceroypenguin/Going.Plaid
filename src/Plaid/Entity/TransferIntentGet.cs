namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a transfer intent within Transfer UI.</para>
/// </summary>
public record TransferIntentGet
{
	/// <summary>
	/// <para>Plaid's unique identifier for a transfer intent object.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The datetime the transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transfer intent.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.TransferIntentStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for the transfer created through the UI. Returned only if the transfer was successfully created. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string? TransferId { get; init; } = default!;

	/// <summary>
	/// <para>The reason for a failed transfer intent. Returned only if the transfer intent status is <c>failed</c>. Null otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferIntentGetFailureReason? FailureReason { get; init; } = default!;

	/// <summary>
	/// <para>A decision regarding the proposed transfer.</para>
	/// </summary>
	[JsonPropertyName("authorization_decision")]
	public Entity.TransferIntentAuthorizationDecision? AuthorizationDecision { get; init; } = default!;

	/// <summary>
	/// <para>The rationale for Plaid's decision regarding a proposed transfer. It is always set for <c>declined</c> decisions, and may or may not be null for <c>approved</c> decisions.</para>
	/// </summary>
	[JsonPropertyName("authorization_decision_rationale")]
	public Entity.TransferAuthorizationDecisionRationale? AuthorizationDecisionRationale { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the account that will be debited or credited. Returned only if <c>account_id</c> was set on intent creation.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for the origination account used for the transfer.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	[Obsolete]
	public string OriginationAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The id of the funding account to use, available in the Plaid Dashboard. This determines which of your business checking accounts will be credited or debited.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string FundingAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The direction of the flow of transfer funds.</para>
	/// </summary>
	[JsonPropertyName("mode")]
	public Entity.TransferIntentCreateMode Mode { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferIntentCreateNetwork? Network { get; init; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <a href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</a>.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass? AchClass { get; init; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferUserInResponse User { get; init; } = default!;

	/// <summary>
	/// <para>A description for the underlying transfer. Maximum of 8 characters.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

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
	/// <para>The currency of the transfer amount, e.g. "USD"</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, the transfer requires a <c>GUARANTEED</c> decision by Plaid to proceed (Guarantee customers only).</para>
	/// </summary>
	[JsonPropertyName("require_guarantee")]
	public bool? RequireGuarantee { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the transfer is guaranteed by Plaid (Guarantee customers only). This field will contain either <c>GUARANTEED</c> or <c>NOT_GUARANTEED</c> indicating whether Plaid will guarantee the transfer.</para>
	/// </summary>
	[JsonPropertyName("guarantee_decision")]
	public Entity.TransferAuthorizationGuaranteeDecision? GuaranteeDecision { get; init; } = default!;

	/// <summary>
	/// <para>The rationale for Plaid's decision to not guarantee a transfer. Will be <c>null</c> unless <c>guarantee_decision</c> is <c>NOT_GUARANTEED</c>.</para>
	/// </summary>
	[JsonPropertyName("guarantee_decision_rationale")]
	public Entity.TransferAuthorizationGuaranteeDecisionRationale? GuaranteeDecisionRationale { get; init; } = default!;

}
