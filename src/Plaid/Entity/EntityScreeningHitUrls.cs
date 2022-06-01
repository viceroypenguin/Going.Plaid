namespace Going.Plaid.Entity;

/// <summary>
/// <para>URLs associated with the entity screening hit</para>
/// </summary>
public record EntityScreeningHitUrls
{
	/// <summary>
	/// <para>An 'http' or 'https' URL (must begin with either of those).</para>
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; init; } = default!;
}