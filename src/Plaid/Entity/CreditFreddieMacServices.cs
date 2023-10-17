namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of objects that describe requests and responses for services.</para>
/// </summary>
public record CreditFreddieMacServices
{
	/// <summary>
	/// <para>A collection of details related to a fulfillment service or product in terms of request, process and result.</para>
	/// </summary>
	[JsonPropertyName("SERVICE")]
	public Entity.CreditFreddieMacService Service { get; init; } = default!;
}