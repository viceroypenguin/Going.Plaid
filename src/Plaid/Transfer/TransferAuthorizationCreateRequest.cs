namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/authorization/create</c></para>
/// </summary>
public partial class TransferAuthorizationCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the account that will be debited or credited.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferType Type { get; set; } = default!;

	/// <summary>
	/// <para>The network or rails used for the transfer. Valid options are <c>ach</c> or <c>same-day-ach</c>. The cutoff for same-day transfers is 7:45 AM Pacific Time and the cutoff for next-day transfers is 5:45 PM Pacific Time. It is recommended to submit a transfer at least 15 minutes before the cutoff time in order to ensure that it will be processed before the cutoff. Any transfer that is indicated as <c>same-day-ach</c> and that misses the same-day cutoff, but is submitted in time for the next-day cutoff, will be sent over next-day rails and will not incur same-day charges. Note that both legs of the transfer will be downgraded if applicable.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferNetwork Network { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass AchClass { get; set; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferAuthorizationUserInRequest User { get; set; } = default!;

	/// <summary>
	/// <para>Information about the device being used to initiate the authorization.</para>
	/// </summary>
	[JsonPropertyName("device")]
	public Entity.TransferAuthorizationDevice Device { get; set; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for the origination account for this authorization. If not specified, the default account will be used.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string OriginationAccountId { get; set; } = default!;

	/// <summary>
	/// <para>The currency of the transfer amount. The default value is "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>Required for guaranteed ACH customers. If the end user is initiating the specific transfer themselves via an interactive UI, this should be <c>true</c>; for automatic recurring payments where the end user is not actually initiating each individual transfer, it should be <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("user_present")]
	public bool? UserPresent { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a payment profile.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_id")]
	public string PaymentProfileId { get; set; } = default!;
}