namespace Going.Plaid.Consent;

/// <summary>
/// <para>Describes a historical log of item consent events.</para>
/// </summary>
public record ConsentEventsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of consent events.</para>
	/// </summary>
	[JsonPropertyName("consent_events")]
	public IReadOnlyList<Entity.ConsentEvent> ConsentEvents { get; init; } = default!;

}
