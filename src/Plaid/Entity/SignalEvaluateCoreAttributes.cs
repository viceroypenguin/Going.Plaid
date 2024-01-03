namespace Going.Plaid.Entity;

/// <summary>
/// <para>The core attributes object contains additional data that can be used to assess the ACH return risk. Examples of data include:</para>
/// <para><c>days_since_first_plaid_connection</c>: The number of days since the first time the Item was connected to an application via Plaid</para>
/// <para><c>plaid_connections_count_7d</c>: The number of times the Item has been connected to applications via Plaid over the past 7 days</para>
/// <para><c>plaid_connections_count_30d</c>: The number of times the Item has been connected to applications via Plaid over the past 30 days</para>
/// <para><c>total_plaid_connections_count</c>: The number of times the Item has been connected to applications via Plaid</para>
/// <para><c>is_savings_or_money_market_account</c>: Indicates whether the ACH transaction funding account is a savings/money market account</para>
/// <para>For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact Sales or your Plaid account manager</para>
/// </summary>
public record SignalEvaluateCoreAttributes
{
	/// <summary>
	/// <para>We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 7 days from the account that will be debited.</para>
	/// </summary>
	[JsonPropertyName("unauthorized_transactions_count_7d")]
	public int? UnauthorizedTransactionsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 30 days from the account that will be debited.</para>
	/// </summary>
	[JsonPropertyName("unauthorized_transactions_count_30d")]
	public int? UnauthorizedTransactionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 60 days from the account that will be debited.</para>
	/// </summary>
	[JsonPropertyName("unauthorized_transactions_count_60d")]
	public int? UnauthorizedTransactionsCount60d { get; init; } = default!;

	/// <summary>
	/// <para>We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 90 days from the account that will be debited.</para>
	/// </summary>
	[JsonPropertyName("unauthorized_transactions_count_90d")]
	public int? UnauthorizedTransactionsCount90d { get; init; } = default!;

	/// <summary>
	/// <para>We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 7 days from the account that will be debited.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_7d")]
	public int? NsfOverdraftTransactionsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 30 days from the account that will be debited.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_30d")]
	public int? NsfOverdraftTransactionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 60 days from the account that will be debited.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_60d")]
	public int? NsfOverdraftTransactionsCount60d { get; init; } = default!;

	/// <summary>
	/// <para>We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 90 days from the account that will be debited.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_90d")]
	public int? NsfOverdraftTransactionsCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of days since the first time the Item was connected to an application via Plaid</para>
	/// </summary>
	[JsonPropertyName("days_since_first_plaid_connection")]
	public int? DaysSinceFirstPlaidConnection { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the Item has been connected to applications via Plaid over the past 7 days</para>
	/// </summary>
	[JsonPropertyName("plaid_connections_count_7d")]
	public int? PlaidConnectionsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the Item has been connected to applications via Plaid over the past 30 days</para>
	/// </summary>
	[JsonPropertyName("plaid_connections_count_30d")]
	public int? PlaidConnectionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of times the Item has been connected to applications via Plaid</para>
	/// </summary>
	[JsonPropertyName("total_plaid_connections_count")]
	public int? TotalPlaidConnectionsCount { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if the ACH transaction funding account is a savings/money market account</para>
	/// </summary>
	[JsonPropertyName("is_savings_or_money_market_account")]
	public bool? IsSavingsOrMoneyMarketAccount { get; init; } = default!;

	/// <summary>
	/// <para>The total credit (inflow) transaction amount over the past 10 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("total_credit_transactions_amount_10d")]
	public decimal? TotalCreditTransactionsAmount10d { get; init; } = default!;

	/// <summary>
	/// <para>The total debit (outflow) transaction amount over the past 10 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("total_debit_transactions_amount_10d")]
	public decimal? TotalDebitTransactionsAmount10d { get; init; } = default!;

	/// <summary>
	/// <para>The 50th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p50_credit_transactions_amount_28d")]
	public decimal? P50CreditTransactionsAmount28d { get; init; } = default!;

	/// <summary>
	/// <para>The 50th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p50_debit_transactions_amount_28d")]
	public decimal? P50DebitTransactionsAmount28d { get; init; } = default!;

	/// <summary>
	/// <para>The 95th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p95_credit_transactions_amount_28d")]
	public decimal? P95CreditTransactionsAmount28d { get; init; } = default!;

	/// <summary>
	/// <para>The 95th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p95_debit_transactions_amount_28d")]
	public decimal? P95DebitTransactionsAmount28d { get; init; } = default!;

	/// <summary>
	/// <para>The number of days within the past 90 days when the account that will be debited had a negative end-of-day available balance</para>
	/// </summary>
	[JsonPropertyName("days_with_negative_balance_count_90d")]
	public int? DaysWithNegativeBalanceCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The 90th percentile of the end-of-day available balance over the past 30 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p90_eod_balance_30d")]
	public decimal? P90EodBalance30d { get; init; } = default!;

	/// <summary>
	/// <para>The 90th percentile of the end-of-day available balance over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p90_eod_balance_60d")]
	public decimal? P90EodBalance60d { get; init; } = default!;

	/// <summary>
	/// <para>The 90th percentile of the end-of-day available balance over the past 90 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p90_eod_balance_90d")]
	public decimal? P90EodBalance90d { get; init; } = default!;

	/// <summary>
	/// <para>The 10th percentile of the end-of-day available balance over the past 30 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p10_eod_balance_30d")]
	public decimal? P10EodBalance30d { get; init; } = default!;

	/// <summary>
	/// <para>The 10th percentile of the end-of-day available balance over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p10_eod_balance_60d")]
	public decimal? P10EodBalance60d { get; init; } = default!;

	/// <summary>
	/// <para>The 10th percentile of the end-of-day available balance over the past 90 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p10_eod_balance_90d")]
	public decimal? P10EodBalance90d { get; init; } = default!;

	/// <summary>
	/// <para>Available balance, as of the <c>balance_last_updated</c> time. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.</para>
	/// </summary>
	[JsonPropertyName("available_balance")]
	public decimal? AvailableBalance { get; init; } = default!;

	/// <summary>
	/// <para>Current balance, as of the <c>balance_last_updated</c> time. The current balance is the total amount of funds in the account.</para>
	/// </summary>
	[JsonPropertyName("current_balance")]
	public decimal? CurrentBalance { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the balance for the given account has been updated.</para>
	/// </summary>
	[JsonPropertyName("balance_last_updated")]
	public DateTimeOffset? BalanceLastUpdated { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's phone numbers on file have changed over the past 28 days</para>
	/// </summary>
	[JsonPropertyName("phone_change_count_28d")]
	public int? PhoneChangeCount28d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's phone numbers on file have changed over the past 90 days</para>
	/// </summary>
	[JsonPropertyName("phone_change_count_90d")]
	public int? PhoneChangeCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's email addresses on file have changed over the past 28 days</para>
	/// </summary>
	[JsonPropertyName("email_change_count_28d")]
	public int? EmailChangeCount28d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's email addresses on file have changed over the past 90 days</para>
	/// </summary>
	[JsonPropertyName("email_change_count_90d")]
	public int? EmailChangeCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's addresses on file have changed over the past 28 days</para>
	/// </summary>
	[JsonPropertyName("address_change_count_28d")]
	public int? AddressChangeCount28d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's addresses on file have changed over the past 90 days</para>
	/// </summary>
	[JsonPropertyName("address_change_count_90d")]
	public int? AddressChangeCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of non-OAuth authentication attempts via Plaid for this bank account over the past 3 days</para>
	/// </summary>
	[JsonPropertyName("plaid_non_oauth_authentication_attempts_count_3d")]
	public int? PlaidNonOauthAuthenticationAttemptsCount3d { get; init; } = default!;

	/// <summary>
	/// <para>The number of non-OAuth authentication attempts via Plaid for this bank account over the past 7 days</para>
	/// </summary>
	[JsonPropertyName("plaid_non_oauth_authentication_attempts_count_7d")]
	public int? PlaidNonOauthAuthenticationAttemptsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of non-OAuth authentication attempts via Plaid for this bank account over the past 30 days</para>
	/// </summary>
	[JsonPropertyName("plaid_non_oauth_authentication_attempts_count_30d")]
	public int? PlaidNonOauthAuthenticationAttemptsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 3 days</para>
	/// </summary>
	[JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_3d")]
	public int? FailedPlaidNonOauthAuthenticationAttemptsCount3d { get; init; } = default!;

	/// <summary>
	/// <para>The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 7 days</para>
	/// </summary>
	[JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_7d")]
	public int? FailedPlaidNonOauthAuthenticationAttemptsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 30 days</para>
	/// </summary>
	[JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_30d")]
	public int? FailedPlaidNonOauthAuthenticationAttemptsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of debit (outflow) transactions over the past 10 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("debit_transactions_count_10d")]
	public int? DebitTransactionsCount10d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of credit (inflow) transactions over the past 10 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("credit_transactions_count_10d")]
	public int? CreditTransactionsCount10d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of debit (outflow) transactions over the past 30 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("debit_transactions_count_30d")]
	public int? DebitTransactionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of credit (inflow) transactions over the past 30 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("credit_transactions_count_30d")]
	public int? CreditTransactionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of debit (outflow) transactions over the past 60 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("debit_transactions_count_60d")]
	public int? DebitTransactionsCount60d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of credit (inflow) transactions over the past 60 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("credit_transactions_count_60d")]
	public int? CreditTransactionsCount60d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of debit (outflow) transactions over the past 90 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("debit_transactions_count_90d")]
	public int? DebitTransactionsCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The total number of credit (inflow) transactions over the past 90 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("credit_transactions_count_90d")]
	public int? CreditTransactionsCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The total debit (outflow) transaction amount over the past 30 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("total_debit_transactions_amount_30d")]
	public decimal? TotalDebitTransactionsAmount30d { get; init; } = default!;

	/// <summary>
	/// <para>The total credit (inflow) transaction amount over the past 30 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("total_credit_transactions_amount_30d")]
	public decimal? TotalCreditTransactionsAmount30d { get; init; } = default!;

	/// <summary>
	/// <para>The total debit (outflow) transaction amount over the past 60 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("total_debit_transactions_amount_60d")]
	public decimal? TotalDebitTransactionsAmount60d { get; init; } = default!;

	/// <summary>
	/// <para>The total credit (inflow) transaction amount over the past 60 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("total_credit_transactions_amount_60d")]
	public decimal? TotalCreditTransactionsAmount60d { get; init; } = default!;

	/// <summary>
	/// <para>The total debit (outflow) transaction amount over the past 90 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("total_debit_transactions_amount_90d")]
	public decimal? TotalDebitTransactionsAmount90d { get; init; } = default!;

	/// <summary>
	/// <para>The total credit (inflow) transaction amount over the past 90 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("total_credit_transactions_amount_90d")]
	public decimal? TotalCreditTransactionsAmount90d { get; init; } = default!;

	/// <summary>
	/// <para>The 50th percentile of the end-of-day available balance over the past 30 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p50_eod_balance_30d")]
	public decimal? P50EodBalance30d { get; init; } = default!;

	/// <summary>
	/// <para>The 50th percentile of the end-of-day available balance over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p50_eod_balance_60d")]
	public decimal? P50EodBalance60d { get; init; } = default!;

	/// <summary>
	/// <para>The 50th percentile of the end-of-day available balance over the past 90 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p50_eod_balance_90d")]
	public decimal? P50EodBalance90d { get; init; } = default!;

	/// <summary>
	/// <para>The 50th percentile of the end-of-day available balance between day 31 and day 60 over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p50_eod_balance_31d_to_60d")]
	public decimal? P50EodBalance31dTo60d { get; init; } = default!;

	/// <summary>
	/// <para>The 50th percentile of the end-of-day available balance between day 61 and day 90 over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p50_eod_balance_61d_to_90d")]
	public decimal? P50EodBalance61dTo90d { get; init; } = default!;

	/// <summary>
	/// <para>The 90th percentile of the end-of-day available balance between day 31 and day 60 over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p90_eod_balance_31d_to_60d")]
	public decimal? P90EodBalance31dTo60d { get; init; } = default!;

	/// <summary>
	/// <para>The 90th percentile of the end-of-day available balance between day 61 and day 90 over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p90_eod_balance_61d_to_90d")]
	public decimal? P90EodBalance61dTo90d { get; init; } = default!;

	/// <summary>
	/// <para>The 10th percentile of the end-of-day available balance between day 31 and day 60 over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p10_eod_balance_31d_to_60d")]
	public decimal? P10EodBalance31dTo60d { get; init; } = default!;

	/// <summary>
	/// <para>The 10th percentile of the end-of-day available balance between day 61 and day 90 over the past 60 days of the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("p10_eod_balance_61d_to_90d")]
	public decimal? P10EodBalance61dTo90d { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the transactions for the given account have been updated.</para>
	/// </summary>
	[JsonPropertyName("transactions_last_updated")]
	public DateTimeOffset? TransactionsLastUpdated { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if the receiver bank account is closed</para>
	/// </summary>
	[JsonPropertyName("is_account_closed")]
	public bool? IsAccountClosed { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if the receiver bank account is either frozen or restricted</para>
	/// </summary>
	[JsonPropertyName("is_account_frozen_or_restricted")]
	public bool? IsAccountFrozenOrRestricted { get; init; } = default!;

}
