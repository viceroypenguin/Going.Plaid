namespace Going.Plaid.Entity;

/// <summary>
/// <para>VOA Report information about an account.</para>
/// </summary>
public record CraVoaReportAccount
{
	/// <summary>
	/// <para>Plaid’s unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.</para>
	/// <para>If an account with a specific <c>account_id</c> disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.</para>
	/// <para>Like all Plaid identifiers, the <c>account_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>VOA Report information about an account's balances.</para>
	/// </summary>
	[JsonPropertyName("balances")]
	public Entity.CraVoaReportAccountBalances Balances { get; init; } = default!;

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
	/// <para>The name of the account, either assigned by the user or by the financial institution itself.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The official name of the account as given by the financial institution.</para>
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
	/// <para>Transaction data associated with the account.</para>
	/// </summary>
	[JsonPropertyName("transactions_insights")]
	public Entity.CraVoaReportTransactionsInsights TransactionsInsights { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by the financial institution about the account owner or owners.</para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner> Owners { get; init; } = default!;

	/// <summary>
	/// <para>How an asset is owned.</para>
	/// </summary>
	[JsonPropertyName("ownership_type")]
	public Entity.OwnershipType? OwnershipType { get; init; } = default!;

}
