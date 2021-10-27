namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about a certain reason as to why a document could potentially be fraudulent</para>
/// </summary>
public record FraudAttributes
{
	/// <summary>
	/// <para>Message indicating the reason as to why the verification failed</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.FraudAttributesTypeEnum? Type { get; init; } = default!;
}