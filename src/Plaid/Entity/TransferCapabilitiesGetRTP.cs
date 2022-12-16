namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains the supported service types in RTP</para>
/// </summary>
public record TransferCapabilitiesGetRTP
{
	/// <summary>
	/// <para>When <c>true</c>, meaning the linked item's institution supports RTP credit transfer</para>
	/// </summary>
	[JsonPropertyName("credit")]
	public bool Credit { get; init; } = default!;
}