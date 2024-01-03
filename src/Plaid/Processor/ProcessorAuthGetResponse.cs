namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorAuthGetResponse defines the response schema for <c>/processor/auth/get</c></para>
/// </summary>
public record ProcessorAuthGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An object containing identifying numbers used for making electronic transfers to and from the <c>account</c>. The identifying number type (ACH, EFT, IBAN, or BACS) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by the <c>account</c> for which auth data has been requested, a null value will be returned.</para>
	/// </summary>
	[JsonPropertyName("numbers")]
	public Entity.ProcessorNumber Numbers { get; init; } = default!;

	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;

}
