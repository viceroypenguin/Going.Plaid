namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata of the income stream's next payment.</para>
/// </summary>
public record CraIncomeNextPayment
{
	/// <summary>
	/// <para>The expected date of the income stream's next payment. The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; init; } = default!;

}
