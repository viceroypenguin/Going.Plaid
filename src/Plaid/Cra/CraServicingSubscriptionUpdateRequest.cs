namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraServicingSubscriptionUpdateRequest defines the request schema for <c>/cra/servicing/subscription/update</c>. It follows field-mask semantics: omitted fields are left unchanged, while provided fields overwrite the current value. To clear a field, include its name in <c>reset_fields</c>.</para>
/// </summary>
public partial class CraServicingSubscriptionUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>A CRA servicing subscription identifier, in the format <c>cra-sub-&lt;environment&gt;-&lt;uuid&gt;</c>.</para>
	/// </summary>
	[JsonPropertyName("subscription_id")]
	public string SubscriptionId { get; set; } = default!;

	/// <summary>
	/// <para>The URL to which the webhook should be sent. If provided, this will override the URL set in the dashboard.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The products included in this subscription. If provided, this replaces the subscription's entire product list.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraSubscriptionProductConfig>? Products { get; set; } = default!;

	/// <summary>
	/// <para>A list of fields to reset back to their default value. Fields named here take precedence over any value provided for the same field elsewhere in the request.</para>
	/// </summary>
	[JsonPropertyName("reset_fields")]
	public IReadOnlyList<Entity.CraServicingSubscriptionUpdateRequestResettableField>? ResetFields { get; set; } = default!;

}
