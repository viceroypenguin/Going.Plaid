namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights into negative balance occurrences, including frequency, duration, and minimum balance details.</para>
/// </summary>
public record NegativeBalanceInsights
{
	/// <summary>
	/// <para>The number of days since the last transaction that caused any account in the report to have a negative balance.</para>
	/// <para>This value is inclusive of the date of the last negative balance, meaning that if the last negative balance occurred today, this value will be <c>0</c>.</para>
	/// </summary>
	[JsonPropertyName("days_since_last_occurrence")]
	public int? DaysSinceLastOccurrence { get; init; } = default!;

	/// <summary>
	/// <para>The number of aggregated days that the accounts in the report has had a negative balance within the given time window.</para>
	/// </summary>
	[JsonPropertyName("days_with_negative_balance")]
	public int? DaysWithNegativeBalance { get; init; } = default!;

	/// <summary>
	/// <para>A monetary amount with its associated currency information, supporting both official and unofficial currency codes.</para>
	/// </summary>
	[JsonPropertyName("minimum_balance")]
	public Entity.AmountWithCurrency? MinimumBalance { get; init; } = default!;

	/// <summary>
	/// <para>The summary of the negative balance occurrences for this account.</para>
	/// <para>If the user has not had a negative balance in the account in the given time window, this list will be empty.</para>
	/// </summary>
	[JsonPropertyName("occurrences")]
	public IReadOnlyList<Entity.NegativeBalanceOccurrence>? Occurrences { get; init; } = default!;

}
