namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraServicingSubscriptionListResponse defines the response schema for <c>/cra/servicing/subscription/list</c>.</para>
/// </summary>
public record CraServicingSubscriptionListResponse : ResponseBase
{
	/// <summary>
	/// <para>All CRA servicing subscriptions for the user, across scopes.</para>
	/// </summary>
	[JsonPropertyName("subscriptions")]
	public IReadOnlyList<Entity.CraServicingSubscription> Subscriptions { get; init; } = default!;

}
