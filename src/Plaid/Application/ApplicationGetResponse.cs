namespace Going.Plaid.Application;

/// <summary>
/// <para>ApplicationGetResponse defines the response schema for <c>/application/get</c></para>
/// </summary>
public record ApplicationGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Metadata about the application</para>
	/// </summary>
	[JsonPropertyName("application")]
	public Entity.Application Application { get; init; } = default!;

}
