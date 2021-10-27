namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata specifically related to valid Payment Initiation standing order configurations for the institution.</para>
/// </summary>
public record PaymentInitiationStandingOrderMetadata
{
	/// <summary>
	/// <para>Indicates whether the institution supports closed-ended standing orders by providing an end date.</para>
	/// </summary>
	[JsonPropertyName("supports_standing_order_end_date")]
	public bool SupportsStandingOrderEndDate { get; init; } = default!;

	/// <summary>
	/// <para>This is only applicable to <c>MONTHLY</c> standing orders. Indicates whether the institution supports negative integers (-1 to -5) for setting up a <c>MONTHLY</c> standing order relative to the end of the month.</para>
	/// </summary>
	[JsonPropertyName("supports_standing_order_negative_execution_days")]
	public bool SupportsStandingOrderNegativeExecutionDays { get; init; } = default!;

	/// <summary>
	/// <para>A list of the valid standing order intervals supported by the institution.</para>
	/// </summary>
	[JsonPropertyName("valid_standing_order_intervals")]
	public IReadOnlyList<Entity.PaymentScheduleInterval> ValidStandingOrderIntervals { get; init; } = default!;
}