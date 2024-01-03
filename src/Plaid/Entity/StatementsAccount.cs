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
	/// <para>The name of the account, either assigned by the user or by the financial institution itself.</para>
	/// </summary>
	[JsonPropertyName("account_name")]
	public string AccountName { get; init; } = default!;

	/// <summary>
	/// <para>The type of account. Possible values are investment, credit, depository, loan, brokerage, other.</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string AccountType { get; init; } = default!;

	/// <summary>
	/// <para>The list of statements' metadata associated with this account.</para>
	/// </summary>
	[JsonPropertyName("statements")]
	public IReadOnlyList<Entity.StatementsStatement> Statements { get; init; } = default!;

}
