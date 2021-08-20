namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing identifying numbers used for making electronic transfers to and from the <c>accounts</c>. The identifying number type (ACH, EFT, IBAN, or BACS) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by any <c>accounts</c> for which data has been requested, the array for that type will be empty.</para>
/// </summary>
public record AuthGetNumbers
{
	/// <summary>
	/// <para>An array of ACH numbers identifying accounts.</para>
	/// </summary>
	[JsonPropertyName("ach")]
	public IReadOnlyList<Entity.NumbersAch> Ach { get; init; } = default!;

	/// <summary>
	/// <para>An array of EFT numbers identifying accounts.</para>
	/// </summary>
	[JsonPropertyName("eft")]
	public IReadOnlyList<Entity.NumbersEft> Eft { get; init; } = default!;

	/// <summary>
	/// <para>An array of IBAN numbers identifying accounts.</para>
	/// </summary>
	[JsonPropertyName("international")]
	public IReadOnlyList<Entity.NumbersInternational> International { get; init; } = default!;

	/// <summary>
	/// <para>An array of BACS numbers identifying accounts.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public IReadOnlyList<Entity.NumbersBacs> Bacs { get; init; } = default!;
}