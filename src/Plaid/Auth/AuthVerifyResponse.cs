namespace Going.Plaid.Auth;

/// <summary>
/// <para>AuthVerifyResponse defines the response schema for <c>/auth/verify</c></para>
/// </summary>
public record AuthVerifyResponse : ResponseBase
{
	/// <summary>
	/// <para>The <c>item_id</c> value of the Item created for verification. If numbers data provided is invalid, an item may not be created.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Indicates the Item's database verification status. Possible values are:</para>
	/// <para><c>database_insights_fail</c>: The Item's numbers have been verified using Plaid's data sources and have signal for being invalid and/or have no signal for being valid. Typically this indicates that the routing number is invalid, the account number does not match the account number format associated with the routing number, or the account has been reported as closed or frozen. Only returned for Auth Items created via Database Auth.</para>
	/// <para><c>database_insights_pass</c>: The Item's numbers have been verified using Plaid's data sources: the routing and account number match a routing and account number of an account recognized on the Plaid network, and the account is not known by Plaid to be frozen or closed. Only returned for Auth Items created via Database Auth.</para>
	/// <para><c>database_insights_pass_with_caution</c>: The Item's numbers have been verified using Plaid's data sources and have some signal for being valid: the routing and account number were not recognized on the Plaid network, but the routing number is valid and the account number is a potential valid account number for that routing number. Only returned for Auth Items created via Database Auth.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public string VerificationStatus { get; init; } = default!;

	/// <summary>
	/// <para>Insights from performing database verification for the account. Only returned for Auth Items using Database Auth.</para>
	/// </summary>
	[JsonPropertyName("verification_insights")]
	public Entity.VerificationInsights VerificationInsights { get; init; } = default!;

}
