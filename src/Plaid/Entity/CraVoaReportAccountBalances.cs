namespace Going.Plaid.Entity;

/// <summary>
/// <para>VOA Report information about an account's balances.</para>
/// </summary>
public record CraVoaReportAccountBalances
{
	/// <summary>
	/// <para>The amount of funds available to be withdrawn from the account, as determined by the financial institution.</para>
	/// <para>For <c>credit</c>-type accounts, the <c>available</c> balance typically equals the <c>limit</c> less the <c>current</c> balance, less any pending outflows plus any pending inflows.</para>
	/// <para>For <c>depository</c>-type accounts, the <c>available</c> balance typically equals the <c>current</c> balance less any pending outflows plus any pending inflows. For <c>depository</c>-type accounts, the <c>available</c> balance does not include the overdraft limit.</para>
	/// <para>For <c>investment</c>-type accounts (or <c>brokerage</c>-type accounts for API versions 2018-05-22 and earlier), the <c>available</c> balance is the total cash available to withdraw as presented by the institution.</para>
	/// <para>Note that not all institutions calculate the <c>available</c>  balance. In the event that <c>available</c> balance is unavailable, Plaid will return an <c>available</c> balance value of <c>null</c>.</para>
	/// <para>Available balance may be cached and is not guaranteed to be up-to-date in realtime unless the value was returned by <c>/accounts/balance/get</c>.</para>
	/// <para>If <c>current</c> is <c>null</c> this field is guaranteed not to be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("available")]
	public decimal? Available { get; init; } = default!;

	/// <summary>
	/// <para>The total amount of funds in or owed by the account.</para>
	/// <para>For <c>credit</c>-type accounts, a positive balance indicates the amount owed; a negative amount indicates the lender owing the account holder.</para>
	/// <para>For <c>loan</c>-type accounts, the current balance is the principal remaining on the loan, except in the case of student loan accounts at Sallie Mae (<c>ins_116944</c>). For Sallie Mae student loans, the account's balance includes both principal and any outstanding interest.</para>
	/// <para>For <c>investment</c>-type accounts (or <c>brokerage</c>-type accounts for API versions 2018-05-22 and earlier), the current balance is the total value of assets as presented by the institution.</para>
	/// <para>Note that balance information may be cached unless the value was returned by <c>/accounts/balance/get</c>; if the Item is enabled for Transactions, the balance will be at least as recent as the most recent Transaction update. If you require realtime balance information, use the <c>available</c> balance as provided by <c>/accounts/balance/get</c>.</para>
	/// <para>When returned by <c>/accounts/balance/get</c>, this field may be <c>null</c>. When this happens, <c>available</c> is guaranteed not to be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("current")]
	public decimal? Current { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the balance. Always null if <c>unofficial_currency_code</c> is non-null.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the balance. Always null if <c>iso_currency_code</c> is non-null. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>unofficial_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>Calculated data about the historical balances on the account.</para>
	/// </summary>
	[JsonPropertyName("historical_balances")]
	public IReadOnlyList<Entity.CraVoaReportAccountHistoricalBalance> HistoricalBalances { get; init; } = default!;

	/// <summary>
	/// <para>The average balance in the account over the last 30 days. Calculated using the derived historical balances.</para>
	/// </summary>
	[JsonPropertyName("average_balance_30_days")]
	public decimal? AverageBalance30Days { get; init; } = default!;

	/// <summary>
	/// <para>The average balance in the account over the last 60 days. Calculated using the derived historical balances.</para>
	/// </summary>
	[JsonPropertyName("average_balance_60_days")]
	public decimal? AverageBalance60Days { get; init; } = default!;

	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the time range for the report in the given account.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count")]
	public decimal NsfOverdraftTransactionsCount { get; init; } = default!;

}
