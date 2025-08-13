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

	/// <summary>
	/// <para>The maximum amount (decimal string with two digits of precision e.g. "10.00") for originating RfP transfers with the given institution.</para>
	/// </summary>
	[JsonPropertyName("max_amount")]
	public string? MaxAmount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the <c>max_amount</c>, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

}
