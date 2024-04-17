namespace Going.Plaid.Entity;

/// <summary>
/// <para>The attributes object contains data that can be used to assess account risk. Examples of data include:</para>
/// <para><c>days_since_first_plaid_connection</c>: The number of days since the first time the Item was connected to an application via Plaid</para>
/// <para><c>plaid_connections_count_7d</c>: The number of times the Item has been connected to applications via Plaid over the past 7 days</para>
/// <para><c>plaid_connections_count_30d</c>: The number of times the Item has been connected to applications via Plaid over the past 30 days</para>
/// <para><c>total_plaid_connections_count</c>: The number of times the Item has been connected to applications via Plaid</para>
/// <para>For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact Sales or your Plaid account manager</para>
/// </summary>
public record BeaconAccountRiskEvaluateAccountAttributes
{
	/// <summary>
	/// <para>The number of days since the first time the Item was connected to an application via Plaid</para>
	/// </summary>
	[JsonPropertyName("days_since_first_plaid_connection")]
	public int? DaysSinceFirstPlaidConnection { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if the account has been closed by the financial institution or the consumer, or is at risk of being closed</para>
	/// </summary>
	[JsonPropertyName("is_account_closed")]
	public bool? IsAccountClosed { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the account has withdrawals and transfers disabled or if access to the account is restricted. This could be due to a freeze by the credit issuer, legal restrictions (e.g., sanctions), or regulatory requirements limiting monthly withdrawals, among other reasons</para>
	/// </summary>
	[JsonPropertyName("is_account_frozen_or_restricted")]
	public bool? IsAccountFrozenOrRestricted { get; init; } = default!;

	/// <summary>
	/// <para>The total number of times the item has been connected to applications via Plaid</para>
	/// </summary>
	[JsonPropertyName("total_plaid_connections_count")]
	public int? TotalPlaidConnectionsCount { get; init; } = default!;

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
	/// <para>The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 3 days</para>
	/// </summary>
	[JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_3d")]
	public int? FailedPlaidNonOauthAuthenticationAttemptsCount3d { get; init; } = default!;

	/// <summary>
	/// <para>The number of non-OAuth authentication attempts via Plaid for this bank account over the past 3 days</para>
	/// </summary>
	[JsonPropertyName("plaid_non_oauth_authentication_attempts_count_3d")]
	public int? PlaidNonOauthAuthenticationAttemptsCount3d { get; init; } = default!;

	/// <summary>
	/// <para>The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 7 days</para>
	/// </summary>
	[JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_7d")]
	public int? FailedPlaidNonOauthAuthenticationAttemptsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of non-OAuth authentication attempts via Plaid for this bank account over the past 7 days</para>
	/// </summary>
	[JsonPropertyName("plaid_non_oauth_authentication_attempts_count_7d")]
	public int? PlaidNonOauthAuthenticationAttemptsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of failed non-OAuth authentication attempts via Plaid for this bank account over the past 30 days</para>
	/// </summary>
	[JsonPropertyName("failed_plaid_non_oauth_authentication_attempts_count_30d")]
	public int? FailedPlaidNonOauthAuthenticationAttemptsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of non-OAuth authentication attempts via Plaid for this bank account over the past 30 days</para>
	/// </summary>
	[JsonPropertyName("plaid_non_oauth_authentication_attempts_count_30d")]
	public int? PlaidNonOauthAuthenticationAttemptsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 3 days</para>
	/// </summary>
	[JsonPropertyName("distinct_ip_addresses_count_3d")]
	public int? DistinctIpAddressesCount3d { get; init; } = default!;

	/// <summary>
	/// <para>The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 7 days</para>
	/// </summary>
	[JsonPropertyName("distinct_ip_addresses_count_7d")]
	public int? DistinctIpAddressesCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 30 days</para>
	/// </summary>
	[JsonPropertyName("distinct_ip_addresses_count_30d")]
	public int? DistinctIpAddressesCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of distinct IP addresses linked to the same bank account during Plaid authentication in the last 90 days</para>
	/// </summary>
	[JsonPropertyName("distinct_ip_addresses_count_90d")]
	public int? DistinctIpAddressesCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of distinct user agents linked to the same bank account during Plaid authentication in the last 3 days</para>
	/// </summary>
	[JsonPropertyName("distinct_user_agents_count_3d")]
	public int? DistinctUserAgentsCount3d { get; init; } = default!;

	/// <summary>
	/// <para>The number of distinct user agents linked to the same bank account during Plaid authentication in the last 7 days</para>
	/// </summary>
	[JsonPropertyName("distinct_user_agents_count_7d")]
	public int? DistinctUserAgentsCount7d { get; init; } = default!;

	/// <summary>
	/// <para>The number of distinct user agents linked to the same bank account during Plaid authentication in the last 30 days</para>
	/// </summary>
	[JsonPropertyName("distinct_user_agents_count_30d")]
	public int? DistinctUserAgentsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of distinct user agents linked to the same bank account during Plaid authentication in the last 90 days</para>
	/// </summary>
	[JsonPropertyName("distinct_user_agents_count_90d")]
	public int? DistinctUserAgentsCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's addresses on file have changed over the past 28 days</para>
	/// </summary>
	[JsonPropertyName("address_change_count_28d")]
	public int? AddressChangeCount28d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's email addresses on file have changed over the past 28 days</para>
	/// </summary>
	[JsonPropertyName("email_change_count_28d")]
	public int? EmailChangeCount28d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's phone numbers on file have changed over the past 28 days</para>
	/// </summary>
	[JsonPropertyName("phone_change_count_28d")]
	public int? PhoneChangeCount28d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's addresses on file have changed over the past 90 days</para>
	/// </summary>
	[JsonPropertyName("address_change_count_90d")]
	public int? AddressChangeCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's email addresses on file have changed over the past 90 days</para>
	/// </summary>
	[JsonPropertyName("email_change_count_90d")]
	public int? EmailChangeCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of times the account's phone numbers on file have changed over the past 90 days</para>
	/// </summary>
	[JsonPropertyName("phone_change_count_90d")]
	public int? PhoneChangeCount90d { get; init; } = default!;

	/// <summary>
	/// <para>The number of days since the bank account was opened, as reported by the financial institution</para>
	/// </summary>
	[JsonPropertyName("days_since_account_opening")]
	public int? DaysSinceAccountOpening { get; init; } = default!;

}
