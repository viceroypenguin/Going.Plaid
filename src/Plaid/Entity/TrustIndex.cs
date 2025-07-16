namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a calculate Trust Index Score.</para>
/// </summary>
public record TrustIndex
{
	/// <summary>
	/// <para>The overall trust index score.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>The versioned name of the Trust Index model used for scoring.</para>
	/// </summary>
	[JsonPropertyName("model")]
	public string Model { get; init; } = default!;

	/// <summary>
	/// <para>Contains sub-score metadata.</para>
	/// </summary>
	[JsonPropertyName("subscores")]
	public Entity.TrustIndexSubscores? Subscores { get; init; } = default!;

}
