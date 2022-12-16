namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the pay period.</para>
/// </summary>
public record PayStubPayPeriodDetails
{
	/// <summary>
	/// <para>The amount of the paycheck.</para>
	/// </summary>
	[JsonPropertyName("pay_amount")]
	public decimal? PayAmount { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("distribution_breakdown")]
	public IReadOnlyList<Entity.PayStubDistributionBreakdown> DistributionBreakdown { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the pay period ended, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>Total earnings before tax/deductions.</para>
	/// </summary>
	[JsonPropertyName("gross_earnings")]
	public decimal? GrossEarnings { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the net pay. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the pay stub was issued, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("pay_date")]
	public DateOnly? PayDate { get; init; } = default!;

	/// <summary>
	/// <para>The frequency at which an individual is paid.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public string? PayFrequency { get; init; } = default!;

	/// <summary>
	/// <para>The explicit pay basis on the paystub (if present).</para>
	/// </summary>
	[JsonPropertyName("pay_basis")]
	public Entity.CreditPayStubPayBasisType PayBasis { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the pay period started, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the net pay. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;
}