namespace Going.Plaid.Entity;

/// <summary>
/// <para>This is a container object for all lending-related insights. This field will be returned only for European customers.</para>
/// </summary>
public record AccountInsights
{
	/// <summary>
	/// <para>Risk indicators focus on providing signal on the possibility of a borrower defaulting on their loan repayments</para>
	/// <para>by providing data points related to its payment behavior, debt, and other relevant financial information,</para>
	/// <para>helping lenders gauge the level of risk involved in a certain operation.</para>
	/// </summary>
	[JsonPropertyName("risk")]
	public Entity.RiskIndicators? Risk { get; init; } = default!;

	/// <summary>
	/// <para>Affordability insights focus on providing signal on the ability of a borrower to repay their loan without experiencing financial strain.</para>
	/// <para>It provides insights on factors such a user's monthly income / expenses, disposable income, average expenditure, etc.,</para>
	/// <para>helping lenders gauge the level of affordability of a borrower.</para>
	/// </summary>
	[JsonPropertyName("affordability")]
	public Entity.AffordabilityInsights? Affordability { get; init; } = default!;

}
