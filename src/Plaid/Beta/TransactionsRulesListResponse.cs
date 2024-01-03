namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsRulesListResponse defines the response schema for <c>/beta/transactions/rules/v1/list</c></para>
/// </summary>
public record TransactionsRulesListResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of the Item's transaction rules</para>
	/// </summary>
	[JsonPropertyName("rules")]
	public IReadOnlyList<Entity.TransactionsCategoryRule> Rules { get; init; } = default!;

}
