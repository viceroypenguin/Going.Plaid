namespace Going.Plaid.Entity;

/// <summary>
/// <para>The set of results for a link session</para>
/// </summary>
public record CreditSessionResults
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("item_add_results")]
	public IReadOnlyList<Entity.CreditSessionItemAddResult> ItemAddResults { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bank_income_results")]
	public IReadOnlyList<Entity.CreditSessionBankIncomeResult> BankIncomeResults { get; init; } = default!;
}