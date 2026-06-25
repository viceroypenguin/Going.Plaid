namespace Going.Plaid.Entity;

/// <summary>
/// <para>Adaptive guarantee details for a transfer, including the guaranteed amount and settlement schedule. Omitted when no guarantee was attempted.</para>
/// </summary>
public record TransferGuaranteeDetails
{
	/// <summary>
	/// <para>The amount currently covered by Plaid's guarantee (decimal string with two digits of precision e.g. "10.00"). This may change over time as scheduled tranches reach their observation window expiration and become guaranteed.</para>
	/// </summary>
	[JsonPropertyName("guaranteed_amount")]
	public string GuaranteedAmount { get; init; } = default!;

	/// <summary>
	/// <para>The adaptive guarantee settlement schedule for this transfer.</para>
	/// </summary>
	[JsonPropertyName("schedule")]
	public IReadOnlyList<Entity.TransferGuaranteeScheduleItem> Schedule { get; init; } = default!;

}
