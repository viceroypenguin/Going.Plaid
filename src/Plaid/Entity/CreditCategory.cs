namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information describing the intent of the transaction. Most relevant for credit use cases, but not limited to such use cases. Please reach out to your account manager or sales representative if you would like to receive this field.</para>
/// <para>See the <a href="https://plaid.com/documents/credit-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of credit categories.</para>
/// </summary>
public record CreditCategory
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