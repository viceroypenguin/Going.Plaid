namespace Going.Plaid.Institutions;

/// <summary>
/// <para>InstitutionsGetByIdResponse defines the response schema for <c>/institutions/get_by_id</c></para>
/// </summary>
public record InstitutionsGetByIdResponse : ResponseBase
{
	/// <summary>
	/// <para>Details relating to a specific financial institution</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public Entity.Institution Institution { get; init; } = default!;
}