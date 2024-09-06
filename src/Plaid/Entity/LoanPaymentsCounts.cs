namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the insights in the number of loan payments</para>
/// </summary>
public record LoanPaymentsCounts
{
	/// <summary>
	/// <para>The number of loan payments made in the 30 days before the subscription date</para>
	/// </summary>
	[JsonPropertyName("baseline_count")]
	public decimal BaselineCount { get; init; } = default!;

	/// <summary>
	/// <para>The current number of loan payments made in the last 30 days</para>
	/// </summary>
	[JsonPropertyName("current_count")]
	public decimal CurrentCount { get; init; } = default!;

}
