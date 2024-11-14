namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/intent/create</c></para>
/// </summary>
public partial class TransferIntentCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; set; } = default!;

	/// <summary>
	/// <para>Specify the account used to fund the transfer. Should be specified if using legacy funding methods only. If using Plaid Ledger, leave this field blank. Customers can find a list of <c>funding_account_id</c>s in the Accounts page of your Plaid Dashboard, under the "Account ID" column. If this field is left blank and you are using legacy funding methods, this will default to the default <c>funding_account_id</c> specified during onboarding. Otherwise, Plaid Ledger will be used.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string? FundingAccountId { get; set; } = default!;

	/// <summary>
	/// <para>The direction of the flow of transfer funds.</para>
	/// </summary>
	[JsonPropertyName("mode")]
	public Entity.TransferIntentCreateMode Mode { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferIntentCreateNetwork? Network { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00"). When calling <c>/transfer/authorization/create</c>, specify the maximum amount to authorize. When calling <c>/transfer/create</c>, specify the exact amount of the transfer, up to a maximum of the amount authorized. If this field is left blank when calling <c>/transfer/create</c>, the maximum amount authorized in the <c>authorization_id</c> will be sent.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>A description for the underlying transfer. Maximum of 15 characters.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <a href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</a>.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass? AchClass { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for the origination account for the intent. If not provided, the default account will be used.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferUserInRequest User { get; set; } = default!;

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
	/// <para>The currency of the transfer amount, e.g. "USD"</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, the transfer requires a <c>GUARANTEED</c> decision by Plaid to proceed (Guarantee customers only).</para>
	/// </summary>
	[JsonPropertyName("require_guarantee")]
	public bool? RequireGuarantee { get; set; } = default!;

}
