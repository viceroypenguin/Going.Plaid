namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a transfer intent within Transfer UI.</para>
/// </summary>
public record TransferIntentCreate
{
	/// <summary>
	/// <para>Plaid's unique identifier for the transfer intent object.</para>
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
	/// <para>The Plaid <c>account_id</c> corresponding to the end-user account that will be debited or credited. Returned only if <c>account_id</c> was set on intent creation.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for the origination account for the intent. If not provided, the default account will be used.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
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
	/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network.</para>
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

}
