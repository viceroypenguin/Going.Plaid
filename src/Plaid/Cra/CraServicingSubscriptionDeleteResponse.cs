namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraServicingSubscriptionDeleteResponse defines the response schema for <c>/cra/servicing/subscription/delete</c>.</para>
/// </summary>
public record CraServicingSubscriptionDeleteResponse : ResponseBase
{
	/// <summary>
	/// <para>A CRA servicing subscription identifier, in the format <c>cra-sub-&lt;environment&gt;-&lt;uuid&gt;</c>.</para>
	/// </summary>
	[JsonPropertyName("subscription_id")]
	public string SubscriptionId { get; init; } = default!;

}
