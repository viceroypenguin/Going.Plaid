namespace Going.Plaid.Entity;

/// <summary>
/// <para>The amount of income earned year to date, as based on paystub data.</para>
/// </summary>
public record PaystubYTDDetails
{
	/// <summary>
	/// <para>Year-to-date gross earnings.</para>
	/// </summary>
	[JsonPropertyName("gross_earnings")]
	public decimal GrossEarnings { get; init; } = default!;

	/// <summary>
	/// <para>Year-to-date net (take home) earnings.</para>
	/// </summary>
	[JsonPropertyName("net_earnings")]
	public decimal NetEarnings { get; init; } = default!;
}