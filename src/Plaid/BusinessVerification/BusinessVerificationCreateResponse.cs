namespace Going.Plaid.BusinessVerification;

/// <summary>
/// <para>A business verification represents a check of a business's identity and risk profile, including information collected about the business and results from third-party data providers.</para>
/// </summary>
public record BusinessVerificationCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated business verification.</para>
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
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("redacted_at")]
	public DateTimeOffset? RedactedAt { get; init; } = default!;

	/// <summary>
	/// <para>Status of the overall business verification</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.BusinessVerificationStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The business information that was used to perform the verification search</para>
	/// </summary>
	[JsonPropertyName("search_terms")]
	public Entity.BusinessSearchTerms SearchTerms { get; init; } = default!;

	/// <summary>
	/// <para>Results from the KYB (Know Your Business) identity verification check</para>
	/// </summary>
	[JsonPropertyName("kyb_check")]
	public Entity.BusinessKYBCheck? KybCheck { get; init; } = default!;

	/// <summary>
	/// <para>Results from the business risk assessment check</para>
	/// </summary>
	[JsonPropertyName("risk_check")]
	public Entity.BusinessRiskCheck? RiskCheck { get; init; } = default!;

}
