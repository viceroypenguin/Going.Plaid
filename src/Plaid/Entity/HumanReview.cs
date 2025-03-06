namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the human review check, which refers to a check that is performed by a document specialist.</para>
/// </summary>
public record HumanReview
{
	/// <summary>
	/// <para>The outcome of the human review check, when available. The following values are possible:</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.HumanReviewStatus Status { get; init; } = default!;

}
