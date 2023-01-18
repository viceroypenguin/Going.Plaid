namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record ValidationSources
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("VALIDATION_SOURCE")]
	public IReadOnlyList<Entity.ValidationSource> ValidationSource { get; init; } = default!;
}