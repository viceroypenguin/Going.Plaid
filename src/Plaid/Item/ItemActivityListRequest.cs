namespace Going.Plaid.Item;

/// <summary>
/// <para>Request to list a historical log of user consent events.</para>
/// </summary>
public partial class ItemActivityListRequest : RequestBase
{
	/// <summary>
	/// <para>Cursor used for pagination.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

}
