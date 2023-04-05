namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata related to the recipient. If the information required to populate this field is not available, leave it blank.</para>
/// </summary>
public class LinkDeliveryRecipient
{
	/// <summary>
	/// <para>The list of communication methods to send the Link Delivery URL to. If delivery is not required, leave this field blank.</para>
	/// </summary>
	[JsonPropertyName("communication_methods")]
	public IReadOnlyList<Entity.LinkDeliveryCommunicationMethod>? CommunicationMethods { get; set; } = default!;

	/// <summary>
	/// <para>First name of the recipient. Will be used in the body of the email / text (if configured). If this information is not available, leave this field blank.</para>
	/// </summary>
	[JsonPropertyName("first_name")]
	public string? FirstName { get; set; } = default!;
}