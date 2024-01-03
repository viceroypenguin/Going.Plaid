namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines an expected sweep date and amount.</para>
/// </summary>
public record TransferExpectedSweepSettlementScheduleItem
{
	/// <summary>
	/// <para>The settlement date of a sweep for this transfer.</para>
	/// </summary>
	[JsonPropertyName("sweep_settlement_date")]
	public DateOnly SweepSettlementDate { get; init; } = default!;

	/// <summary>
	/// <para>The accumulated amount that has been swept by <c>sweep_settlement_date</c>.</para>
	/// </summary>
	[JsonPropertyName("swept_settled_amount")]
	public string SweptSettledAmount { get; init; } = default!;

}
