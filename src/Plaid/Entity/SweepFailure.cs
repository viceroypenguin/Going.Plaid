namespace Going.Plaid.Entity;

/// <summary>
/// <para>The failure reason if the status for a sweep is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.</para>
/// </summary>
public record SweepFailure
{
	/// <summary>
	/// <para>The failure code, e.g. <c>R01</c>.  A failure code will be provided if and only if the sweep status is <c>returned</c>. See <a href="https://plaid.com/docs/errors/transfer/#ach-return-codes">ACH return codes</a> for a full listing of ACH return codes and <a href="https://plaid.com/docs/errors/transfer/#rtprfp-error-codes">RTP/RfP error codes</a> for RTP error codes.</para>
	/// </summary>
	[JsonPropertyName("failure_code")]
	public string? FailureCode { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable description of the reason for the failure or reversal.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; init; } = default!;

}
