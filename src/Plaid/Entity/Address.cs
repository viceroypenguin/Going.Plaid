namespace Going.Plaid.Entity;

/// <summary>
/// <para>A physical mailing address.</para>
/// </summary>
public record Address
{
	/// <summary>
	/// <para>Data about the components comprising an address.</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.AddressData Data { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, identifies the address as the primary address on an account.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public bool Primary { get; init; } = default!;
}