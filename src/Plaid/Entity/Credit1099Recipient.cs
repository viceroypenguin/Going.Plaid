namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a recipient used in both 1099-K and 1099-MISC tax documents.</para>
/// </summary>
public record Credit1099Recipient
{
	/// <summary>
	/// <para>Address on the pay stub.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.CreditPayStubAddress? Address { get; init; } = default!;

	/// <summary>
	/// <para>Name of recipient.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>Tax identification number of recipient.</para>
	/// </summary>
	[JsonPropertyName("tin")]
	public string? Tin { get; init; } = default!;

	/// <summary>
	/// <para>Account number number of recipient.</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string? AccountNumber { get; init; } = default!;

	/// <summary>
	/// <para>Checked if FACTA is a filing requirement.</para>
	/// </summary>
	[JsonPropertyName("facta_filing_requirement")]
	public string? FactaFilingRequirement { get; init; } = default!;

	/// <summary>
	/// <para>Checked if 2nd TIN exists.</para>
	/// </summary>
	[JsonPropertyName("second_tin_exists")]
	public string? SecondTinExists { get; init; } = default!;

}
