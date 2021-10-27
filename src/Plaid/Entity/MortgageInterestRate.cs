namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing metadata about the interest rate for the mortgage.</para>
/// </summary>
public record MortgageInterestRate
{
	/// <summary>
	/// <para>Percentage value (interest rate of current mortgage, not APR) of interest payable on a loan.</para>
	/// </summary>
	[JsonPropertyName("percentage")]
	public decimal? Percentage { get; init; } = default!;

	/// <summary>
	/// <para>The type of interest charged (fixed or variable).</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;
}