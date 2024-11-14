namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional information for the individual SMS verification.</para>
/// </summary>
public record SMSVerification
{
	/// <summary>
	/// <para>The outcome status for the individual SMS verification.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.SMSVerificationStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The attempt field begins with 1 and increments with each subsequent SMS verification.</para>
	/// </summary>
	[JsonPropertyName("attempt")]
	public int Attempt { get; init; } = default!;

	/// <summary>
	/// <para>A phone number in E.164 format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>The number of delivery attempts made within the verification to send the SMS code to the user. Each delivery attempt represents the user taking action from the front end UI to request creation and delivery of a new SMS verification code, or to resend an existing SMS verification code. There is a limit of 3 delivery attempts per verification.</para>
	/// </summary>
	[JsonPropertyName("delivery_attempt_count")]
	public int DeliveryAttemptCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of attempts made by the user within the verification to verify the SMS code by entering it into the front end UI. There is a limit of 3 solve attempts per verification.</para>
	/// </summary>
	[JsonPropertyName("solve_attempt_count")]
	public int SolveAttemptCount { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("initially_sent_at")]
	public DateTimeOffset? InitiallySentAt { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("last_sent_at")]
	public DateTimeOffset? LastSentAt { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("redacted_at")]
	public DateTimeOffset? RedactedAt { get; init; } = default!;

}
