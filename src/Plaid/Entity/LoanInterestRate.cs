namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the interest rate on a loan or line of credit.</para>
/// </summary>
public record LoanInterestRate
{
	/// <summary>
	/// <para>The interest rate percentage.</para>
	/// </summary>
	[JsonPropertyName("percentage")]
	public decimal? Percentage { get; init; } = default!;

	/// <summary>
	/// <para>The type of interest rate.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.LoanInterestRateType? Type { get; init; } = default!;

}
