namespace Going.Plaid.Entity;

/// <summary>
/// <para>Base Report information about an account</para>
/// </summary>
public record BaseReportAccount
{
	/// <summary>
	/// <para>Plaid’s unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.</para>
	/// <para>If an account with a specific <c>account_id</c> disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.</para>
	/// <para>Like all Plaid identifiers, the <c>account_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Information about an account's balances.</para>
	/// </summary>
	[JsonPropertyName("balances")]
	public Entity.BaseReportAccountBalances Balances { get; init; } = default!;

	/// <summary>
	/// <para>The information about previously submitted valid dispute statements by the consumer</para>
	/// </summary>
	[JsonPropertyName("consumer_disputes")]
	public IReadOnlyList<Entity.ConsumerDispute> ConsumerDisputes { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the extracted account.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.BaseReportAccountMetadata Metadata { get; init; } = default!;

	/// <summary>
	/// <para>The name of the account, either assigned by the user or by the financial institution itself</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The official name of the account as given by the financial institution</para>
	/// </summary>
	[JsonPropertyName("official_name")]
	public string? OfficialName { get; init; } = default!;

	/// <summary>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account type schema</a> for a full listing of account types and corresponding subtypes.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.AccountType Type { get; init; } = default!;

	/// <summary>
	/// <para>See the [Account type schema](https://plaid.com/docs/api/accounts/#account-type-schema) for a full listing of account types and corresponding subtypes.</para>
	/// </summary>
	[JsonPropertyName("subtype")]
	public Entity.AccountSubtype? Subtype { get; init; } = default!;

	/// <summary>
	/// <para>The duration of transaction history available within this report for this Item, typically defined as the time since the date of the earliest transaction in that account.</para>
	/// </summary>
	[JsonPropertyName("days_available")]
	public decimal DaysAvailable { get; init; } = default!;

	/// <summary>
	/// <para>Transaction history associated with the account. Transaction history returned by endpoints such as <c>/transactions/get</c> or <c>/investments/transactions/get</c> will be returned in the top-level <c>transactions</c> field instead.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.BaseReportTransaction> Transactions { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by the financial institution about the account owner or owners. For business accounts, the name reported may be either the name of the individual or the name of the business, depending on the institution. Multiple owners on a single account will be represented in the same <c>owner</c> object, not in multiple owner objects within the array. This array can also be empty if no owners are found.</para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner> Owners { get; init; } = default!;

	/// <summary>
	/// <para>How an asset is owned.</para>
	/// </summary>
	[JsonPropertyName("ownership_type")]
	public Entity.OwnershipType? OwnershipType { get; init; } = default!;

	/// <summary>
	/// <para>Calculated data about the historical balances on the account. Currently not supported by <c>brokerage</c> or <c>investment</c> accounts.</para>
	/// </summary>
	[JsonPropertyName("historical_balances")]
	public IReadOnlyList<Entity.BaseReportHistoricalBalance>? HistoricalBalances { get; init; } = default!;

	/// <summary>
	/// <para>Calculated insights derived from transaction-level data. This field has been deprecated in favor of <a href="https://plaid.com/docs/api/products/check/#cra-check_report-base_report-get-response-report-attributes">Base Report attributes aggregated across accounts</a> and will be removed in a future release.</para>
	/// </summary>
	[JsonPropertyName("account_insights")]
	[Obsolete]
	public Entity.BaseReportAccountInsights? AccountInsights { get; init; } = default!;

	/// <summary>
	/// <para>Calculated attributes derived from transaction-level data.</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.BaseReportAttributes? Attributes { get; init; } = default!;

}
