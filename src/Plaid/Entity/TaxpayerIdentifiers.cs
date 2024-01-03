namespace Going.Plaid.Entity;

/// <summary>
/// <para>The collection of TAXPAYER_IDENTIFICATION elements</para>
/// </summary>
public record TaxpayerIdentifiers
{
	/// <summary>
	/// <para>Information about the Taxpayer identification values assigned to the individual or legal entity.Information about the Taxpayer identification values assigned to the individual or legal entity.</para>
	/// </summary>
	[JsonPropertyName("TAXPAYER_IDENTIFIER")]
	public Entity.TaxpayerIdentifier TaxpayerIdentifier { get; init; } = default!;

}
