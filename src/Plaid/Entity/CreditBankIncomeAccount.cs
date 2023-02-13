namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Item's bank accounts that have the selected data.</para>
/// </summary>
public record CreditBankIncomeAccount
{
	/// <summary>
	/// <para>Plaid's unique identifier for the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number.</para>
	/// <para>Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

	/// <summary>
	/// <para>The name of the bank account.</para>
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
	/// 
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner> Owners { get; init; } = default!;
}