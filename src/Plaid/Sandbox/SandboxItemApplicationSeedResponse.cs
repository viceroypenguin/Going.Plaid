namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxItemApplicationSeedResponse defines the response schema for <c>/sandbox/item/application/seed</c></para>
/// </summary>
public record SandboxItemApplicationSeedResponse : ResponseBase
{
	/// <summary>
	/// <para>The <c>item_id</c> of the newly seeded item representing the application connection.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

}
