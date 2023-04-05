namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the accounts that the payment was distributed to.</para>
/// </summary>
public record DistributionBreakdown
{
	/// <summary>
	/// <para>Name of the account for the given distribution.</para>
	/// </summary>
	[JsonPropertyName("account_name")]
	public string? AccountName { get; init; } = default!;

	/// <summary>
	/// <para>The name of the bank that the payment is being deposited to.</para>
	/// </summary>
	[JsonPropertyName("bank_name")]
	public string? BankName { get; init; } = default!;

	/// <summary>
	/// <para>The amount distributed to this account.</para>
	/// </summary>
	[JsonPropertyName("current_amount")]
	public decimal? CurrentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the net pay. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

	/// <summary>
	/// <para>Type of the account that the paystub was sent to (e.g. 'checking').</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the net pay. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a monetary amount.</para>
	/// </summary>
	[JsonPropertyName("current_pay")]
	public Entity.Pay? CurrentPay { get; init; } = default!;
}