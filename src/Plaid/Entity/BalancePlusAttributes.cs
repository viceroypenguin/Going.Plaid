namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains additional data that can be used to assess the ACH return risk</para>
/// </summary>
public record BalancePlusAttributes
{
	/// <summary>
	/// <para>The number of possible past returns due to unauthorized transactions over the past 7 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("unauthorized_transactions_count_7d")]
	public int? UnauthorizedTransactionsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of possible past returns due to unauthorized transactions over the past 30 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("unauthorized_transactions_count_30d")]
	public int? UnauthorizedTransactionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of possible past returns due to unauthorized transactions over the past 60 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("unauthorized_transactions_count_60d")]
	public int? UnauthorizedTransactionsCount60d { get; init; } = default!;

	/// <summary>
	/// <para>The number of possible past returns due to unauthorized transactions over the past 90 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("unauthorized_transactions_count_90d")]
	public int? UnauthorizedTransactionsCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of possible past returns due to non-sufficient funds/overdrafts over the past 7 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_7d")]
	public int? NsfOverdraftTransactionsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of possible past returns due to non-sufficient funds/overdrafts over the past 30 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_30d")]
	public int? NsfOverdraftTransactionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of possible past returns due to non-sufficient funds/overdrafts over the past 60 days from the account that will be debited</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_60d")]
	public int? NsfOverdraftTransactionsCount60d { get; init; } = default!;

	/// <summary>
	/// <para>The number of possible past returns due to non-sufficient funds/overdrafts over the past 90 days from the account that will be debited</para>
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
