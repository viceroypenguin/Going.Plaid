namespace Going.Plaid.Entity;

/// <summary>
/// <para>Address on the pay stub.</para>
/// </summary>
public record CreditPayStubAddress
{
	/// <summary>
	/// <para>The full city name.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; init; } = default!;

	/// <summary>
	/// <para>The ISO 3166-1 alpha-2 country code.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; init; } = default!;

	/// <summary>
	/// <para>The postal code of the address.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>The region or state.</para>
	/// <para>Example: <c>"NC"</c></para>
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; init; } = default!;

	/// <summary>
	/// <para>The full street address.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string? Street { get; init; } = default!;
}