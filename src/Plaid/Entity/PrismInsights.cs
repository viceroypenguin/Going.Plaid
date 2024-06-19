namespace Going.Plaid.Entity;

/// <summary>
/// <para>The data from the Insights product returned by Prism Data.</para>
/// </summary>
public record PrismInsights
{
	/// <summary>
	/// <para>The version of Prism Data's insights model used.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public int Version { get; init; } = default!;

	/// <summary>
	/// <para>The Insights Result object is a map of cash flow attributes, where the key is a string, and the value is a float or string.</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.PrismInsightsResult? Result { get; init; } = default!;

}
