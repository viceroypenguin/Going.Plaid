namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemProductsTerminateRequest defines the request schema for <c>/item/products/terminate</c></para>
/// </summary>
public partial class ItemProductsTerminateRequest : RequestBase
{
	/// <summary>
	/// <para>The reason for terminating products on the Item.</para>
	/// </summary>
	[JsonPropertyName("reason_code")]
	public Entity.ItemProductsTerminateReasonCode ReasonCode { get; set; } = default!;

	/// <summary>
	/// <para>Additional context or details about the reason for terminating products on the Item. Personally identifiable information, such as an email address or phone number, should not be included in the <c>reason_note</c>.</para>
	/// </summary>
	[JsonPropertyName("reason_note")]
	public string? ReasonNote { get; set; } = default!;

}
