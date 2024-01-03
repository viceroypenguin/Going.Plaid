namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditEmploymentGetResponse defines the response schema for <c>/credit/employment/get</c>.</para>
/// </summary>
public record CreditEmploymentGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Array of employment items.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CreditEmploymentItem> Items { get; init; } = default!;

}
