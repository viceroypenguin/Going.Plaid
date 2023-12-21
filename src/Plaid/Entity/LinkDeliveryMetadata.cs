namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information related to the related to the delivery of the link session to users</para>
/// </summary>
public record LinkDeliveryMetadata
{
	/// <summary>
	/// <para>The communication method used to deliver the Hosted Link session</para>
	/// </summary>
	[JsonPropertyName("communication_method")]
	public Entity.LinkDeliveryWebhookCommunicationMethod? CommunicationMethod { get; init; } = default!;

	/// <summary>
	/// <para>The status of the delivery of the Hosted Link to the user</para>
	/// </summary>
	[JsonPropertyName("delivery_status")]
	public Entity.LinkDeliveryWebhookDeliveryStatus? DeliveryStatus { get; init; } = default!;
}