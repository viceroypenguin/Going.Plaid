namespace Going.Plaid.Entity;

/// <summary>
/// <para>Adaptive guarantee details for a transfer authorization, including the guarantee outcome and settlement schedule. Omitted when no guarantee was attempted.</para>
/// </summary>
public record AuthorizationGuaranteeDetails
{
	/// <summary>
	/// <para>The adaptive guarantee outcome for a transfer.</para>
	/// </summary>
	[JsonPropertyName("outcome")]
	public Entity.TransferGuaranteeOutcome Outcome { get; init; } = default!;

	/// <summary>
	/// <para>The adaptive guarantee settlement schedule for this authorization.</para>
	/// </summary>
	[JsonPropertyName("schedule")]
	public IReadOnlyList<Entity.AuthorizationGuaranteeScheduleItem> Schedule { get; init; } = default!;

}
