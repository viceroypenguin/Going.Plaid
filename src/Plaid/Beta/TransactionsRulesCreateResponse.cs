namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsRulesCreateResponse defines the response schema for <c>/beta/transactions/rules/v1/create</c></para>
/// </summary>
public record TransactionsRulesCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A representation of a transactions category rule.</para>
	/// </summary>
	[JsonPropertyName("rule")]
	public Entity.TransactionsCategoryRule Rule { get; init; } = default!;
}