namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing fields describing property address.</para>
/// </summary>
public record MortgagePropertyAddress
{
	/// <summary>
	/// <para>The city name.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; init; } = default!;

	/// <summary>
	/// <para>The ISO 3166-1 alpha-2 country code.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; init; } = default!;

	/// <summary>
	/// <para>The five or nine digit postal code.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>The region or state (example "NC").</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; init; } = default!;

	/// <summary>
	/// <para>The full street address (example "564 Main Street, Apt 15").</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string? Street { get; init; } = default!;
}