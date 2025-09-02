namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemRemoveRequest defines the request schema for <c>/item/remove</c></para>
/// </summary>
public partial class ItemRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The reason for removing the item</para>
	/// </summary>
	[JsonPropertyName("reason_code")]
	public Entity.ItemRemoveReasonCode? ReasonCode { get; set; } = default!;

	/// <summary>
	/// <para>Additional context or details about the reason for removing the item. Personally identifiable information, such as an email address or phone number, should not be included in the <c>reason_note</c>.</para>
	/// </summary>
	[JsonPropertyName("reason_note")]
	public string? ReasonNote { get; set; } = default!;

}
