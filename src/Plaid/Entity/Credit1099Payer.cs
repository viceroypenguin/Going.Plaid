namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a payer used by 1099-MISC tax documents.</para>
/// </summary>
public record Credit1099Payer
{
	/// <summary>
	/// <para>Address on the pay stub.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.CreditPayStubAddress? Address { get; init; } = default!;

	/// <summary>
	/// <para>Name of payer.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>Tax identification number of payer.</para>
	/// </summary>
	[JsonPropertyName("tin")]
	public string? Tin { get; init; } = default!;

	/// <summary>
	/// <para>Telephone number of payer.</para>
	/// </summary>
	[JsonPropertyName("telephone_number")]
	public string? TelephoneNumber { get; init; } = default!;
}