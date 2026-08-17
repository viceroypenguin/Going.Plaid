namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraServicingSubscriptionDeleteRequest defines the request schema for <c>/cra/servicing/subscription/delete</c>. Removes the subscription identified by <c>subscription_id</c>.</para>
/// </summary>
public partial class CraServicingSubscriptionDeleteRequest : RequestBase
{
	/// <summary>
	/// <para>A CRA servicing subscription identifier, in the format <c>cra-sub-&lt;environment&gt;-&lt;uuid&gt;</c>.</para>
	/// </summary>
	[JsonPropertyName("subscription_id")]
	public string SubscriptionId { get; set; } = default!;

}
