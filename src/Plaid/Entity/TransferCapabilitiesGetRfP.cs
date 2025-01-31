namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains the supported service types in RfP</para>
/// </summary>
public record TransferCapabilitiesGetRfP
{
	/// <summary>
	/// <para>When <c>true</c>, the linked Item's institution supports RfP debit transfer.</para>
	/// </summary>
	[JsonPropertyName("debit")]
	public bool? Debit { get; init; } = default!;

}
