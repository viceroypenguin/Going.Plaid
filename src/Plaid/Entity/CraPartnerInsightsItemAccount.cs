namespace Going.Plaid.Entity;

/// <summary>
/// <para>Account data corresponding to the item from which Partner Insights were generated from</para>
/// </summary>
public record CraPartnerInsightsItemAccount
{
	/// <summary>
	/// <para>Plaid's unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.</para>
	/// <para>If an account with a specific <c>account_id</c> disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.</para>
	/// <para>Like all Plaid identifiers, the <c>account_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number.</para>
	/// <para>Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

	/// <summary>
	/// <para>An object containing metadata about the extracted account.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.CraPartnerInsightsItemAccountMetadata Metadata { get; init; } = default!;

	/// <summary>
	/// <para>The name of the account</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The official name of the bank account.</para>
	/// </summary>
	[JsonPropertyName("official_name")]
	public string? OfficialName { get; init; } = default!;

	/// <summary>
	/// <para>Valid account subtypes for depository accounts. For a list containing descriptions of each subtype, see [Account schemas](https://plaid.com/docs/api/accounts/#StandaloneAccountType-depository).</para>
	/// </summary>
	[JsonPropertyName("subtype")]
	public Entity.DepositoryAccountSubtype Subtype { get; init; } = default!;

	/// <summary>
	/// <para>The account type. This will always be <c>depository</c>.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.CreditBankIncomeAccountType Type { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by the financial institution about the account owner or owners. Identity information is optional, so field may return an empty array.</para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner> Owners { get; init; } = default!;

}
