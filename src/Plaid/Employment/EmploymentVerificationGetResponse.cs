namespace Going.Plaid.Employment;

/// <summary>
/// <para>EmploymentVerificationGetResponse defines the response schema for <c>/employment/verification/get</c>.</para>
/// </summary>
public record EmploymentVerificationGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of employment verification summaries.</para>
	/// </summary>
	[JsonPropertyName("employments")]
	public IReadOnlyList<Entity.EmploymentVerification> Employments { get; init; } = default!;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be <c>null</c> if no error has occurred.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Exceptions.PlaidException? Error { get; init; } = default!;
}