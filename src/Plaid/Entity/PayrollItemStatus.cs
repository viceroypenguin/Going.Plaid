namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the status of the payroll item.</para>
/// </summary>
public record PayrollItemStatus
{
	/// <summary>
	/// <para>Denotes the processing status for the verification.</para>
	/// <para><c>UNKNOWN</c>: The processing status could not be determined.</para>
	/// <para><c>PROCESSING_COMPLETE</c>: The processing has completed and the user has approved for sharing. The data is available to be retrieved.</para>
	/// <para><c>PROCESSING</c>: The verification is still processing. The data is not available yet.</para>
	/// <para><c>FAILED</c>: The processing failed to complete successfully.</para>
	/// <para><c>APPROVAL_STATUS_PENDING</c>: The processing has completed but the user has not yet approved the sharing of the data.</para>
	/// </summary>
	[JsonPropertyName("processing_status")]
	public string? ProcessingStatus { get; init; } = default!;
}