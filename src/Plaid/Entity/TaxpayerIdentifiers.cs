namespace Going.Plaid.Entity;

/// <summary>
/// <para>The collection of <c>TAXPAYER_IDENTIFICATION</c> elements</para>
/// </summary>
public record TaxpayerIdentifiers
{
	/// <summary>
	/// <para>Information about the Taxpayer identification values assigned to the individual or legal entity.</para>
	/// </summary>
	[JsonPropertyName("TAXPAYER_IDENTIFIER")]
	public Entity.TaxpayerIdentifier TaxpayerIdentifier { get; init; } = default!;

}
