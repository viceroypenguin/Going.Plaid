namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the Taxpayer identification values assigned to the individual or legal entity.</para>
/// </summary>
public record TaxpayerIdentifier
{
	/// <summary>
	/// <para>A value from a MISMO prescribed list that classifies identification numbers used by the Internal Revenue Service (IRS) in the administration of tax laws. A Social Security number (SSN) is issued by the SSA; all other taxpayer identification numbers are issued by the IRS.</para>
	/// </summary>
	[JsonPropertyName("TaxpayerIdentifierType")]
	public Entity.TaxpayerIdentifierType? Taxpayeridentifiertype { get; init; } = default!;

	/// <summary>
	/// <para>The value of the taxpayer identifier as assigned by the IRS to the individual or legal entity.</para>
	/// </summary>
	[JsonPropertyName("TaxpayerIdentifierValue")]
	public string? Taxpayeridentifiervalue { get; init; } = default!;

}
