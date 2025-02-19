namespace Going.Plaid.Session;

/// <summary>
/// <para>SessionTokenCreateResponse defines the response schema for <c>/session/token/create</c></para>
/// </summary>
public record SessionTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Response data for <c>/session/token/create</c> intended for use with the Link SDK.</para>
	/// </summary>
	[JsonPropertyName("link")]
	public Entity.SessionTokenCreateResponseLink? Link { get; init; } = default!;

}
