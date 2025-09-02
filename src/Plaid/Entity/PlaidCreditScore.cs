namespace Going.Plaid.Entity;

/// <summary>
/// <para>The results of the Plaid Credit Score</para>
/// </summary>
public record PlaidCreditScore
{
	/// <summary>
	/// <para>The score returned by the Plaid Credit Score model. Will be an integer in the range 1 to 99.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>The reasons for an individual having risk according to the Plaid Credit score.</para>
	/// </summary>
	[JsonPropertyName("reason_codes")]
	public IReadOnlyList<string>? ReasonCodes { get; init; } = default!;

	/// <summary>
	/// <para>Human-readable description of why the Plaid Credit score could not be computed.</para>
	/// </summary>
	[JsonPropertyName("error_reason")]
	public string? ErrorReason { get; init; } = default!;

}
