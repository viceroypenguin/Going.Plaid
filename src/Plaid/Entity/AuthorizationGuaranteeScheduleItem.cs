namespace Going.Plaid.Entity;

/// <summary>
/// <para>A single entry in an authorization's adaptive guarantee settlement schedule, describing one tranche of guaranteed funds.</para>
/// </summary>
public record AuthorizationGuaranteeScheduleItem
{
	/// <summary>
	/// <para>The guaranteed amount for this schedule entry (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The number of business days in the observation window for this tranche. <c>0</c> when the tranche is not subject to an observation window.</para>
	/// </summary>
	[JsonPropertyName("observation_window_business_days")]
	public int ObservationWindowBusinessDays { get; init; } = default!;

}
