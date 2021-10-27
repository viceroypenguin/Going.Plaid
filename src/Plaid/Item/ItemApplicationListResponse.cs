namespace Going.Plaid.Item;

/// <summary>
/// <para>Describes the connected application for a particular end user.</para>
/// </summary>
public record ItemApplicationListResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of connected applications.</para>
	/// </summary>
	[JsonPropertyName("applications")]
	public IReadOnlyList<Entity.ConnectedApplication> Applications { get; init; } = default!;
}