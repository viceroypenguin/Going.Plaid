namespace Going.Plaid.Entity;

/// <summary>
/// <para>Website associated with a business</para>
/// </summary>
public record BusinessWebsite
{
	/// <summary>
	/// <para>URL of the business website</para>
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; init; } = default!;

}
