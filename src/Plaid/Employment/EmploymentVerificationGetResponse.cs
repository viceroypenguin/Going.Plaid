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
}