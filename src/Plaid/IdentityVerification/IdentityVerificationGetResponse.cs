namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>A identity verification attempt represents a customer's attempt to verify their identity, reflecting the required steps for completing the session, the results for each step, and information collected in the process.</para>
/// </summary>
public record IdentityVerificationGetResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated Identity Verification attempt.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("completed_at")]
	public DateTimeOffset? CompletedAt { get; init; } = default!;

	/// <summary>
	/// <para>The ID for the Identity Verification preceding this session. This field will only be filled if the current Identity Verification is a retry of a previous attempt.</para>
	/// </summary>
	[JsonPropertyName("previous_attempt_id")]
	public string? PreviousAttemptId { get; init; } = default!;

	/// <summary>
	/// <para>A shareable URL that can be sent directly to the user to complete verification</para>
	/// </summary>
	[JsonPropertyName("shareable_url")]
	public string? ShareableUrl { get; init; } = default!;

	/// <summary>
	/// <para>The resource ID and version number of the template configuring the behavior of a given identity verification.</para>
	/// </summary>
	[JsonPropertyName("template")]
	public Entity.IdentityVerificationTemplateReference Template { get; init; } = default!;

	/// <summary>
	/// <para>The identity data that was either collected from the user or provided via API in order to perform an identity verification.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.IdentityVerificationUserData User { get; init; } = default!;

	/// <summary>
	/// <para>The status of this Identity Verification attempt.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.IdentityVerificationStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Each step will be one of the following values:</para>
	/// <para><c>active</c> - This step is the user's current step. They are either in the process of completing this step, or they recently closed their Identity Verification attempt while in the middle of this step. Only one step will be marked as <c>active</c> at any given point.</para>
	/// <para><c>success</c> - The Identity Verification attempt has completed this step.</para>
	/// <para><c>failed</c> - The user failed this step. This can either call the user to fail the session as a whole, or cause them to fallback to another step depending on how the Identity Verification template is configured. A failed step does not imply a failed session.</para>
	/// <para><c>waiting_for_prerequisite</c> - The user needs to complete another step first, before they progress to this step. This step may never run, depending on if the user fails an earlier step or if the step is only run as a fallback.</para>
	/// <para><c>not_applicable</c> - This step will not be run for this session.</para>
	/// <para><c>skipped</c> - The retry instructions that created this Identity Verification attempt specified that this step should be skipped.</para>
	/// <para><c>expired</c> - This step had not yet been completed when the Identity Verification attempt as a whole expired.</para>
	/// <para><c>canceled</c> - The Identity Verification attempt was canceled before the user completed this step.</para>
	/// <para><c>pending_review</c> - The Identity Verification attempt template was configured to perform a screening that had one or more hits needing review.</para>
	/// <para><c>manually_approved</c> - The step was manually overridden to pass by a team member in the dashboard.</para>
	/// <para><c>manually_rejected</c> - The step was manually overridden to fail by a team member in the dashboard.</para>
	/// </summary>
	[JsonPropertyName("steps")]
	public Entity.IdentityVerificationStepSummary Steps { get; init; } = default!;

	/// <summary>
	/// <para>Data, images, analysis, and results from the <c>documentary_verification</c> step. This field will be <c>null</c> unless <c>steps.documentary_verification</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.</para>
	/// </summary>
	[JsonPropertyName("documentary_verification")]
	public Entity.DocumentaryVerification? DocumentaryVerification { get; init; } = default!;

	/// <summary>
	/// <para>Additional information for the <c>selfie_check</c> step. This field will be <c>null</c> unless <c>steps.selfie_check</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.</para>
	/// </summary>
	[JsonPropertyName("selfie_check")]
	public Entity.SelfieCheck? SelfieCheck { get; init; } = default!;

	/// <summary>
	/// <para>Additional information for the <c>kyc_check</c> step. This field will be <c>null</c> unless <c>steps.kyc_check</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.</para>
	/// </summary>
	[JsonPropertyName("kyc_check")]
	public Entity.KYCCheckDetails? KycCheck { get; init; } = default!;

	/// <summary>
	/// <para>Additional information for the <c>risk_check</c> step.</para>
	/// </summary>
	[JsonPropertyName("risk_check")]
	public Entity.RiskCheckDetails? RiskCheck { get; init; } = default!;

	/// <summary>
	/// <para>ID of the associated screening.</para>
	/// </summary>
	[JsonPropertyName("watchlist_screening_id")]
	public string? WatchlistScreeningId { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("redacted_at")]
	public DateTimeOffset? RedactedAt { get; init; } = default!;

}
