namespace Going.Plaid.Entity;

/// <summary>
/// <para>Name associated with a business</para>
/// </summary>
public record ProviderBusinessName
{
	/// <summary>
	/// <para>Indicates whether this is the primary name for the business.</para>
	/// </summary>
	[JsonPropertyName("is_primary")]
	public bool IsPrimary { get; init; } = default!;

	/// <summary>
	/// <para>The name of the business. Must have at least one character and a maximum length of 500 characters.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

}
