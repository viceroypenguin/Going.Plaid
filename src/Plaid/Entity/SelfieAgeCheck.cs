namespace Going.Plaid.Entity;

/// <summary>
/// <para>Age-estimation results from the selfie capture. This field is <c>null</c> when an age range could not be estimated from the selfie capture.</para>
/// </summary>
public record SelfieAgeCheck
{
	/// <summary>
	/// <para>An enum indicating whether the reported age aligns with the estimated selfie capture age range.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.SelfieAgeCheckStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The user's age at the time of the selfie capture, calculated from the date of birth submitted during Identity Verification. If multiple date of birth sources are available, the date of birth submitted in the flow session takes priority over the document date of birth. This field is <c>null</c> when the date of birth is unavailable.</para>
	/// </summary>
	[JsonPropertyName("reported_age")]
	public int? ReportedAge { get; init; } = default!;

	/// <summary>
	/// <para>Lower bound of the estimated age range from the selfie capture.</para>
	/// </summary>
	[JsonPropertyName("age_estimate_lower_bound")]
	public int AgeEstimateLowerBound { get; init; } = default!;

	/// <summary>
	/// <para>Upper bound of the estimated age range from the selfie capture.</para>
	/// </summary>
	[JsonPropertyName("age_estimate_upper_bound")]
	public int AgeEstimateUpperBound { get; init; } = default!;

}
