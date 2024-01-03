namespace Going.Plaid.Entity;

/// <summary>
/// <para>The address associated with the account holder.</para>
/// </summary>
public record TransferUserAddressInResponse
{
	/// <summary>
	/// <para>The street number and name (i.e., "100 Market St.").</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string? Street { get; init; } = default!;

	/// <summary>
	/// <para>Ex. "San Francisco"</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; init; } = default!;

	/// <summary>
	/// <para>The state or province (e.g., "CA").</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; init; } = default!;

	/// <summary>
	/// <para>The postal code (e.g., "94103").</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>A two-letter country code (e.g., "US").</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; init; } = default!;

}
