namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about a specific occurrence of a negative balance period, including start and end dates.</para>
/// </summary>
public record NegativeBalanceOccurrence
{
	/// <summary>
	/// <para>The date of the first transaction that caused the account to have a negative balance.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The date of the last transaction that caused the account to have a negative balance.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// <para>This date is inclusive, meaning that this was the last date that the account had a negative balance.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

}
