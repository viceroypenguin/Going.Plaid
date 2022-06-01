namespace Going.Plaid.Entity;

/// <summary>
/// <para>An official document, usually issued by a governing body or institution, with an associated identifier.</para>
/// </summary>
public record EntityDocument
{
	/// <summary>
	/// <para>The kind of official document represented by this object.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.EntityDocumentType Type { get; init; } = default!;

	/// <summary>
	/// <para>The numeric or alphanumeric identifier associated with this document.</para>
	/// </summary>
	[JsonPropertyName("number")]
	public string Number { get; init; } = default!;
}