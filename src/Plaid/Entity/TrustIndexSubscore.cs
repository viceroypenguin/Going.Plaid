namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents Trust Index Subscore.</para>
/// </summary>
public record TrustIndexSubscore
{
	/// <summary>
	/// <para>The subscore score.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

}
