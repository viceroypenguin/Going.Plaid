namespace Going.Plaid.Employers;

/// <summary>
/// <para>EmployersSearchResponse defines the response schema for <c>/employers/search</c>.</para>
/// </summary>
public record EmployersSearchResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of employers matching the search criteria.</para>
	/// </summary>
	[JsonPropertyName("employers")]
	public IReadOnlyList<Entity.Employer> Employers { get; init; } = default!;

}
