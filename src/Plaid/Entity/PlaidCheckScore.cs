namespace Going.Plaid.Entity;

/// <summary>
/// <para>The results of the Plaid Check score. For existing customers only; for new customers, the Plaid Check Score has been replaced by the LendScore, which can be obtained by calling <c>/cra/check_report/lend_score/get</c>.</para>
/// </summary>
public record PlaidCheckScore
{
	/// <summary>
	/// <para>The score returned by the Plaid Check Score model. Will be an integer in the range 1 to 99.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>The reasons for an individual having risk according to the Plaid Check score.</para>
	/// </summary>
	[JsonPropertyName("reason_codes")]
	public IReadOnlyList<string>? ReasonCodes { get; init; } = default!;

	/// <summary>
	/// <para>Human-readable description of why the score could not be computed.</para>
	/// </summary>
	[JsonPropertyName("error_reason")]
	public string? ErrorReason { get; init; } = default!;

}
