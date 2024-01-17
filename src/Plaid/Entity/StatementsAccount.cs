namespace Going.Plaid.Entity;

/// <summary>
/// <para>Account associated with the Item.</para>
/// </summary>
public record StatementsAccount
{
	/// <summary>
	/// <para>Plaid's unique identifier for the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.</para>
	/// </summary>
	[JsonPropertyName("account_mask")]
	public string AccountMask { get; init; } = default!;

	/// <summary>
	/// <para>The name of the account, either assigned by the user or by the financial institution itself.</para>
	/// </summary>
	[JsonPropertyName("account_name")]
	public string AccountName { get; init; } = default!;

	/// <summary>
	/// <para>The official name of the account as given by the financial institution.</para>
	/// </summary>
	[JsonPropertyName("account_official_name")]
	public string AccountOfficialName { get; init; } = default!;

	/// <summary>
	/// <para>The subtype of the account. For a full list of valid types and subtypes, see the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</a>.</para>
	/// </summary>
	[JsonPropertyName("account_subtype")]
	public string AccountSubtype { get; init; } = default!;

	/// <summary>
	/// <para>The type of account. For a full list of valid types and subtypes, see the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</a>.</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string AccountType { get; init; } = default!;

	/// <summary>
	/// <para>The list of statements' metadata associated with this account.</para>
	/// </summary>
	[JsonPropertyName("statements")]
	public IReadOnlyList<Entity.StatementsStatement> Statements { get; init; } = default!;

}
