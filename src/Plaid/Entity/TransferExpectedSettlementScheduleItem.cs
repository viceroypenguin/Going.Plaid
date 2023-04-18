namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines an expected sweep date and amount.</para>
/// </summary>
public record TransferExpectedSettlementScheduleItem
{
	/// <summary>
	/// <para>The settlement date of a sweep for this transfer.</para>
	/// </summary>
	[JsonPropertyName("settlement_date")]
	public DateOnly SettlementDate { get; init; } = default!;

	/// <summary>
	/// <para>The accumulated amount that have been swept by <c>settlement_date</c>.</para>
	/// </summary>
	[JsonPropertyName("settled_amount")]
	public string SettledAmount { get; init; } = default!;
}