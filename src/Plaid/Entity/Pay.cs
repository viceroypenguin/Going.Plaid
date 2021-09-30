namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a monetary amount.</para>
/// </summary>
public record Pay
{
	/// <summary>
	/// <para>A numerical amount of a specific currency.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal? Amount { get; init; } = default!;

	/// <summary>
	/// <para>Currency code, e.g. USD</para>
	/// </summary>
	[JsonPropertyName("currency")]
	public string? Currency { get; init; } = default!;
}