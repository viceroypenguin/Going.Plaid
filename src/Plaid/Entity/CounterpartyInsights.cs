namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights around a user's counterparties</para>
/// </summary>
public record CounterpartyInsights
{
	/// <summary>
	/// <para>Insights related to a user’s transactions with other financial institutions, including detected account types.</para>
	/// </summary>
	[JsonPropertyName("financial_institution_insights")]
	public IReadOnlyList<Entity.FinancialInstitutionInsights>? FinancialInstitutionInsights { get; init; } = default!;

	/// <summary>
	/// <para>Insights about a user’s top merchants, ranked by spend.</para>
	/// </summary>
	[JsonPropertyName("merchant_insights")]
	public IReadOnlyList<Entity.MerchantInsights>? MerchantInsights { get; init; } = default!;

}
