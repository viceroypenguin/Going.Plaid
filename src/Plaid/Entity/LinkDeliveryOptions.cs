namespace Going.Plaid.Entity;

/// <summary>
/// <para>Optional metadata related to the Hosted Link session</para>
/// </summary>
public class LinkDeliveryOptions
{
	/// <summary>
	/// <para>Metadata related to the recipient. If the information required to populate this field is not available, leave it blank.</para>
	/// </summary>
	[JsonPropertyName("recipient")]
	public Entity.LinkDeliveryRecipient? Recipient { get; set; } = default!;
}