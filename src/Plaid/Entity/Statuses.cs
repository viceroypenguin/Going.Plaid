namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of STATUS containers.</para>
/// </summary>
public record Statuses
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("STATUS")]
	public Entity.Status Status { get; init; } = default!;
}