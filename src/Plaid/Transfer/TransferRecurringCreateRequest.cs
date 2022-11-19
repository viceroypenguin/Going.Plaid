namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/recurring/create</c></para>
/// </summary>
public partial class TransferRecurringCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A random key provided by the client, per unique authorization. Maximum of 50 characters.</para>
	/// <para>The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create an authorization fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single authorization is created.</para>
	/// <para>Failure to provide this key may result in duplicate charges.</para>
	/// <para>Required for guaranteed ACH customers.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string? IdempotencyKey { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the account that will be debited or credited. Required if not using <c>payment_profile_token</c>.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

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
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass AchClass { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>If the end user is initiating the specific transfer themselves via an interactive UI, this should be <c>true</c>; for automatic recurring payments where the end user is not actually initiating each individual transfer, it should be <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("user_present")]
	public bool? UserPresent { get; set; } = default!;

	/// <summary>
	/// <para>The currency of the transfer amount. The default value is "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; set; } = default!;

	/// <summary>
	/// <para>The schedule that the recurring transfer will be executed on.</para>
	/// </summary>
	[JsonPropertyName("schedule")]
	public Entity.TransferRecurringSchedule Schedule { get; set; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferUserInRequest User { get; set; } = default!;

	/// <summary>
	/// <para>Information about the device being used to initiate the authorization.</para>
	/// </summary>
	[JsonPropertyName("device")]
	public Entity.TransferDevice Device { get; set; } = default!;
}