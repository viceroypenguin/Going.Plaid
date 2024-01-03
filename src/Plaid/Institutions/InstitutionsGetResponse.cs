namespace Going.Plaid.Institutions;

/// <summary>
/// <para>InstitutionsGetResponse defines the response schema for <c>/institutions/get</c></para>
/// </summary>
public record InstitutionsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of Plaid institutions</para>
	/// </summary>
	[JsonPropertyName("institutions")]
	public IReadOnlyList<Entity.Institution> Institutions { get; init; } = default!;

	/// <summary>
	/// <para>The total number of institutions available via this endpoint</para>
	/// </summary>
	[JsonPropertyName("total")]
	public int Total { get; init; } = default!;

}
