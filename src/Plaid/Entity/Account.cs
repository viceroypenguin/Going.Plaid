namespace Going.Plaid.Entity;

/// <summary>
/// <para>A single account at a financial institution.</para>
/// </summary>
public record Account
{
	/// <summary>
	/// <para>Plaid’s unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.</para>
	/// <para>The <c>account_id</c> can also change if the <c>access_token</c> is deleted and the same credentials that were used to generate that <c>access_token</c> are used to generate a new <c>access_token</c> on a later date. In that case, the new <c>account_id</c> will be different from the old <c>account_id</c>.</para>
	/// <para>If an account with a specific <c>account_id</c> disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.</para>
	/// <para>Like all Plaid identifiers, the <c>account_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>A set of fields describing the balance for an account. Balance information may be cached unless the balance object was returned by <c>/accounts/balance/get</c>.</para>
	/// </summary>
	[JsonPropertyName("balances")]
	public Entity.AccountBalance Balances { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

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
	/// <para>The current verification status of an Auth Item initiated through Automated or Manual micro-deposits.  Returned for Auth Items only.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.AccountVerificationStatusEnum? VerificationStatus { get; init; } = default!;

	/// <summary>
	/// <para>A unique and persistent identifier for accounts that can be used to trace multiple instances of the same account across different Items for depository accounts. This is currently an opt-in field and only supported for Chase Items.</para>
	/// </summary>
	[JsonPropertyName("persistent_account_id")]
	public string? PersistentAccountId { get; init; } = default!;

}
