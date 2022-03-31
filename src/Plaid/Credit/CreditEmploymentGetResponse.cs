namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditEmploymentGetResponse defines the response schema for <c>/credit/employment/get</c>.</para>
/// </summary>
public record CreditEmploymentGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of employment verification summaries.</para>
	/// </summary>
	[JsonPropertyName("employments")]
	public IReadOnlyList<Entity.CreditEmploymentVerification> Employments { get; init; } = default!;
}