namespace Going.Plaid.Entity;

/// <summary>
/// <para>A single entry in the adaptive guarantee settlement schedule, describing one tranche of guaranteed funds. Adds <c>observation_window_expiration_time</c>, which is only known once a transfer is created.</para>
/// </summary>
public record TransferGuaranteeScheduleItem
{
	/// <summary>
	/// <para>The guaranteed amount for this schedule entry (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string? Amount { get; init; } = default!;

	/// <summary>
	/// <para>The number of business days in the observation window for this tranche. <c>0</c> when the tranche is not subject to an observation window.</para>
	/// </summary>
	[JsonPropertyName("observation_window_business_days")]
	public int? ObservationWindowBusinessDays { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when the observation window for this tranche expires. Present only when the tranche is subject to an observation window. This will be of the form <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("observation_window_expiration_time")]
	public DateTimeOffset? ObservationWindowExpirationTime { get; init; } = default!;

}
