namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying values for the <c>facial_duplicate</c> attributes of risk check.</para>
/// </summary>
public record RiskCheckFacialDuplicate
{
	/// <summary>
	/// <para>ID of the associated Identity Verification attempt.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>Similarity score of the match. Ranges from 0 to 100.</para>
	/// </summary>
	[JsonPropertyName("similarity")]
	public int Similarity { get; init; } = default!;

	/// <summary>
	/// <para>Whether this match occurred after the session was complete. For example, this would be <c>true</c> if a later session ended up matching this one.</para>
	/// </summary>
	[JsonPropertyName("matched_after_completed")]
	public bool MatchedAfterCompleted { get; init; } = default!;

}
