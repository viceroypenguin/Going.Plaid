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
	/// <para>Indicates an Item's micro-deposit-based verification or database verification status. This field is only populated when using Auth and falling back to micro-deposit or database verification. Possible values are:</para>
	/// <para><c>pending_automatic_verification</c>: The Item is pending automatic verification</para>
	/// <para><c>pending_manual_verification</c>: The Item is pending manual micro-deposit verification. Items remain in this state until the user successfully verifies the code.</para>
	/// <para><c>automatically_verified</c>: The Item has successfully been automatically verified</para>
	/// <para><c>manually_verified</c>: The Item has successfully been manually verified</para>
	/// <para><c>verification_expired</c>: Plaid was unable to automatically verify the deposit within 7 calendar days and will no longer attempt to validate the Item. Users may retry by submitting their information again through Link.</para>
	/// <para><c>verification_failed</c>: The Item failed manual micro-deposit verification because the user exhausted all 3 verification attempts. Users may retry by submitting their information again through Link.</para>
	/// <para><c>database_insights_pending</c>: The Database Auth result is pending and will be available upon Auth request.</para>
	/// <para><c>database_insights_fail</c>: The Item's numbers have been verified using Plaid's data sources and have signal for being invalid and/or have no signal for being valid. Typically this indicates that the routing number is invalid, the account number does not match the account number format associated with the routing number, or the account has been reported as closed or frozen. Only returned for Auth Items created via Database Auth.</para>
	/// <para><c>database_insights_pass</c>: The Item's numbers have been verified using Plaid's data sources: the routing and account number match a routing and account number of an account recognized on the Plaid network, and the account is not known by Plaid to be frozen or closed. Only returned for Auth Items created via Database Auth.</para>
	/// <para><c>database_insights_pass_with_caution</c>: The Item's numbers have been verified using Plaid's data sources and have some signal for being valid: the routing and account number were not recognized on the Plaid network, but the routing number is valid and the account number is a potential valid account number for that routing number. Only returned for Auth Items created via Database Auth.</para>
	/// <para><c>database_matched</c>: (deprecated) The Item has successfully been verified using Plaid's data sources. Only returned for Auth Items created via Database Match.</para>
	/// <para><c>null</c> or empty string: Neither micro-deposit-based verification nor database verification are being used for the Item.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public string? VerificationStatus { get; init; } = default!;

	/// <summary>
	/// <para>If micro-deposit verification was being used, indicates the user's selection when asked if the account being verified is a <c>business</c> or <c>personal</c> account. This field is deprecated as Plaid no longer collects this information during the micro-deposit flow. To see whether an account is business or personal, use the <c>holder_category</c> field instead.</para>
	/// </summary>
	[JsonPropertyName("class_type")]
	[Obsolete]
	public string? ClassType { get; init; } = default!;

}
