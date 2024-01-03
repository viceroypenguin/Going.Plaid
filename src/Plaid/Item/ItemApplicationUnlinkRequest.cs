namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemApplicationUnlinkRequest defines the request schema for <c>/item/application/unlink/</c></para>
/// </summary>
public partial class ItemApplicationUnlinkRequest : RequestBase
{
	/// <summary>
	/// <para>This field will map to the application ID that is returned from /item/application/list, or provided to the institution in an oauth redirect.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string ApplicationId { get; set; } = default!;

}
