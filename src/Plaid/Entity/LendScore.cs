namespace Going.Plaid.Entity;

/// <summary>
/// <para>The results of the LendScore</para>
/// </summary>
public record LendScore
{
	/// <summary>
	/// <para>The score returned by the LendScore model. Will be an integer in the range 1 to 99. Higher scores indicate lower credit risk.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>The reasons for an individual having risk according to the LendScore. For a full list of possible reason codes, contact your Plaid Account Manager. Different LendScore versions will use different sets of reason codes.</para>
	/// </summary>
	[JsonPropertyName("reason_codes")]
	public IReadOnlyList<string>? ReasonCodes { get; init; } = default!;

	/// <summary>
	/// <para>Human-readable description of why the LendScore could not be computed.</para>
	/// </summary>
	[JsonPropertyName("error_reason")]
	public string? ErrorReason { get; init; } = default!;

}
