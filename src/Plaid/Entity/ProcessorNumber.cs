namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing identifying numbers used for making electronic transfers to and from the <c>account</c>. The identifying number type (ACH, EFT, IBAN, or BACS) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by the <c>account</c> for which auth data has been requested, a null value will be returned.</para>
/// </summary>
public record ProcessorNumber
{
	/// <summary>
	/// <para>Identifying information for transferring money to or from a US account via ACH or wire transfer.</para>
	/// </summary>
	[JsonPropertyName("ach")]
	public Entity.NumbersAch? Ach { get; init; } = default!;

	/// <summary>
	/// <para>Identifying information for transferring money to or from a Canadian bank account via EFT.</para>
	/// </summary>
	[JsonPropertyName("eft")]
	public Entity.NumbersEft? Eft { get; init; } = default!;

	/// <summary>
	/// <para>Identifying information for transferring money to or from an international bank account via wire transfer.</para>
	/// </summary>
	[JsonPropertyName("international")]
	public Entity.NumbersInternational? International { get; init; } = default!;

	/// <summary>
	/// <para>Identifying information for transferring money to or from a UK bank account via BACS.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.NumbersBacs? Bacs { get; init; } = default!;

}
