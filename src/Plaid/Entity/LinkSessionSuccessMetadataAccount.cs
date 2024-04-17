namespace Going.Plaid.Entity;

/// <summary>
/// <para>An account attached to the connected Item.</para>
/// </summary>
public record LinkSessionSuccessMetadataAccount
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c></para>
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; init; } = default!;

	/// <summary>
	/// <para>The official account name</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts. It may also not match the mask that the bank displays to the user.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

	/// <summary>
	/// <para>The account type. See the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</a> for a full list of possible values</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;

	/// <summary>
	/// <para>The account subtype. See the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</a> for a full list of possible values</para>
	/// </summary>
	[JsonPropertyName("subtype")]
	public string? Subtype { get; init; } = default!;

	/// <summary>
	/// <para>Indicates an Item's micro-deposit-based verification status. Possible values are:</para>
	/// <para><c>pending_automatic_verification</c>: The Item is pending automatic verification</para>
	/// <para><c>pending_manual_verification</c>: The Item is pending manual micro-deposit verification. Items remain in this state until the user successfully verifies the code.</para>
	/// <para><c>automatically_verified</c>: The Item has successfully been automatically verified</para>
	/// <para><c>manually_verified</c>: The Item has successfully been manually verified</para>
	/// <para><c>verification_expired</c>: Plaid was unable to automatically verify the deposit within 7 calendar days and will no longer attempt to validate the Item. Users may retry by submitting their information again through Link.</para>
	/// <para><c>verification_failed</c>: The Item failed manual micro-deposit verification because the user exhausted all 3 verification attempts. Users may retry by submitting their information again through Link.</para>
	/// <para><c>database_matched</c>: The Item has successfully been verified using Plaid's data sources.</para>
	/// <para><c>database_insights_pass</c>: The Item's account and routing number pair has been verified against a known account using Plaid's data sources and has strong signal for being valid. Note: Database Insights is currently a beta feature, please contact your account manager for more information.</para>
	/// <para><c>database_insights_pass_with_caution</c>: The Item's account and routing number pair was unable to be verified against a known account using Plaid's data sources. However, the routing number has strong signal for being valid, and the account number format is consistent with other known account numbers used with the given routing number. Note: Database Insights is currently a beta feature, please contact your account manager for more information.</para>
	/// <para><c>database_insights_fail</c>: The Item's account and routing number pair has been checked using Plaid's data sources and has signal for being invalid and/or has no signal for being valid. Note: Database Insights is currently a beta feature, please contact your account manager for more information.</para>
	/// <para><c>null</c>: micro-deposit-based verification is not being used for the Item.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public string? VerificationStatus { get; init; } = default!;

	/// <summary>
	/// <para>If micro-deposit verification is being used, indicates whether the account being verified is a <c>business</c> or <c>personal</c> account.</para>
	/// </summary>
	[JsonPropertyName("class_type")]
	public string? ClassType { get; init; } = default!;

}
