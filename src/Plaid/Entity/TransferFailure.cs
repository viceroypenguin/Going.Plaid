namespace Going.Plaid.Entity;

/// <summary>
/// <para>The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.</para>
/// </summary>
public class TransferFailure
{
	/// <summary>
	/// <para>The failure code, e.g. <c>R01</c>.  A failure code will be provided if and only if the transfer status is <c>returned</c>. See <a href="https://plaid.com/docs/errors/transfer/#ach-return-codes">ACH return codes</a> for a full listing of ACH return codes and <a href="https://plaid.com/docs/errors/transfer/#rtprfp-error-codes">RTP/RfP error codes</a> for RTP error codes.</para>
	/// </summary>
	[JsonPropertyName("failure_code")]
	public string? FailureCode { get; set; } = default!;

	/// <summary>
	/// <para>The ACH return code, e.g. <c>R01</c>.  A return code will be provided if and only if the transfer status is <c>returned</c>. For a full listing of ACH return codes, see <a href="https://plaid.com/docs/errors/transfer/#ach-return-codes">Transfer errors</a>.</para>
	/// </summary>
	[JsonPropertyName("ach_return_code")]
	[Obsolete]
	public string? AchReturnCode { get; set; } = default!;

	/// <summary>
	/// <para>A human-readable description of the reason for the failure or reversal.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; } = default!;

}
