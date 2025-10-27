namespace Going.Plaid.Entity;

/// <summary>
/// <para>A set of fields describing the investments data on an account.</para>
/// </summary>
public record BaseReportInvestments
{
	/// <summary>
	/// <para>Quantities and values of securities held in the investment account. Map to the <c>securities</c> array for security details.</para>
	/// </summary>
	[JsonPropertyName("holdings")]
	public IReadOnlyList<Entity.BaseReportInvestmentHolding> Holdings { get; init; } = default!;

	/// <summary>
	/// <para>Details of specific securities held in the investment account.</para>
	/// </summary>
	[JsonPropertyName("securities")]
	public IReadOnlyList<Entity.BaseReportInvestmentSecurity> Securities { get; init; } = default!;

	/// <summary>
	/// <para>Transaction history on the investment account.</para>
	/// </summary>
	[JsonPropertyName("investment_transactions")]
	public IReadOnlyList<Entity.BaseReportInvestmentTransaction> InvestmentTransactions { get; init; } = default!;

}
