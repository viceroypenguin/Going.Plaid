namespace Going.Plaid.Entity;

/// <summary>
/// <para>The data from the Insights product returned by Prism.</para>
/// </summary>
public record PrismInsights
{
	/// <summary>
	/// <para>The version of Prism's insights model used.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public int Version { get; init; } = default!;

	/// <summary>
	/// <para>The Insights Result object is a map of cash flow attributes, in string to float format.</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.PrismInsightsResult? Result { get; init; } = default!;

}
