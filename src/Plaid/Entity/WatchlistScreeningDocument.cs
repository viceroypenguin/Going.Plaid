namespace Going.Plaid.Entity;

/// <summary>
/// <para>An official document, usually issued by a governing body or institution, with an associated identifier.</para>
/// </summary>
public record WatchlistScreeningDocument
{
	/// <summary>
	/// <para>The kind of official document represented by this object.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.WatchlistScreeningDocumentType Type { get; init; } = default!;

	/// <summary>
	/// <para>The numeric or alphanumeric identifier associated with this document. Must be between 4 and 32 characters long, and cannot have leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("number")]
	public string Number { get; init; } = default!;

}
