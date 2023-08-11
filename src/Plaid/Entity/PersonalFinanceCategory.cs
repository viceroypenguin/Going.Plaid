namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.</para>
/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
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

	/// <summary>
	/// <para>Note: This field is only available for <c>/transactions/enrich</c> endpoint currently.</para>
	/// <para>A description of how confident we are that the provided categories accurately describe the transaction intent.</para>
	/// <para><c>VERY_HIGH</c>: We are more than 98% confident that this category reflects the intent of the transaction.</para>
	/// <para><c>HIGH</c>: We are more than 90% confident that this category reflects the intent of the transaction.</para>
	/// <para><c>MEDIUM</c>: We are moderately confident that this category reflects the intent of the transaction.</para>
	/// <para><c>LOW</c>: This category may reflect the intent, but there may be other categories that are more accurate.</para>
	/// <para><c>UNKNOWN</c>: Error</para>
	/// </summary>
	[JsonPropertyName("confidence_level")]
	public string? ConfidenceLevel { get; init; } = default!;
}