namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsRulesListResponse defines the response schema for <c>/transactions/rules/list</c></para>
/// </summary>
public record TransactionsRulesListResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of the Item's transaction rules</para>
	/// </summary>
	[JsonPropertyName("rules")]
	public IReadOnlyList<Entity.TransactionsCategoryRule> Rules { get; init; } = default!;
}