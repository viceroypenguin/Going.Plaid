namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.</para>
/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
/// <para>We’re introducing Category Rules - a new beta endpoint that will enable you to change the personal_finance_category for a transaction based on your users’ needs.</para>
/// <para>When rules are set, the selected category will override the Plaid provided category. To learn more, send a note to transactions-feedback@plaid.com.</para>
/// </summary>
public record PersonalFinanceCategory
{
	/// <summary>
	/// <para>A high level category that communicates the broad category of the transaction.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public string Primary { get; init; } = default!;

	/// <summary>
	/// <para>A granular category conveying the transaction's intent. This field can also be used as a unique identifier for the category.</para>
	/// </summary>
	[JsonPropertyName("detailed")]
	public string Detailed { get; init; } = default!;
}