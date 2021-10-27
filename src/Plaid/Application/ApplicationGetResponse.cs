namespace Going.Plaid.Application;

/// <summary>
/// <para>The request ID associated with this call.</para>
/// </summary>
public record ApplicationGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Metadata about the application</para>
	/// </summary>
	[JsonPropertyName("application")]
	public Entity.Application Application { get; init; } = default!;
}