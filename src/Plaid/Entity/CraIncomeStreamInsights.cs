namespace Going.Plaid.Entity;

/// <summary>
/// <para>Modeled insights for a given income stream.</para>
/// </summary>
public record CraIncomeStreamInsights
{
	/// <summary>
	/// <para>The income category for a given stream. The streams returned in the response will be filtered based on these primary and secondary income categories.</para>
	/// <para>See the <a href="https://plaid.com/documents/income-v2-category-taxonomy.csv">Income V2 Category Taxonomy</a> for a full list of income categories.</para>
	/// </summary>
	[JsonPropertyName("income_category")]
	public Entity.CraIncomeCategory IncomeCategory { get; init; } = default!;

	/// <summary>
	/// <para>The income pay frequency.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public Entity.CreditBankIncomePayFrequency PayFrequency { get; init; } = default!;

	/// <summary>
	/// <para>The object containing data about the income provider.</para>
	/// </summary>
	[JsonPropertyName("income_provider")]
	public Entity.CraBankIncomeIncomeProvider? IncomeProvider { get; init; } = default!;

	/// <summary>
	/// <para>The status of the income sources.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.CraBankIncomeStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Metadata of the income stream's next payment.</para>
	/// </summary>
	[JsonPropertyName("next_payment")]
	public Entity.CraIncomeNextPayment? NextPayment { get; init; } = default!;

}
