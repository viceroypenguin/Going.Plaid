namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraServicingSubscriptionGetResponse defines the response schema for <c>/cra/servicing/subscription/get</c>.</para>
/// </summary>
public record CraServicingSubscriptionGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A single CRA servicing subscription.</para>
	/// </summary>
	[JsonPropertyName("subscription")]
	public Entity.CraServicingSubscription Subscription { get; init; } = default!;

}
