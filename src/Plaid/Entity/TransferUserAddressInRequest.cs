namespace Going.Plaid.Entity;

/// <summary>
/// <para>The address associated with the account holder.</para>
/// </summary>
public partial class TransferUserAddressInRequest : RequestBase
{
	/// <summary>
	/// <para>The street number and name (i.e., "100 Market St.").</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string Street { get; set; } = default!;

	/// <summary>
	/// <para>Ex. "San Francisco"</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; } = default!;

	/// <summary>
	/// <para>The state or province (e.g., "CA").</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; set; } = default!;

	/// <summary>
	/// <para>The postal code (e.g., "94103").</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>A two-letter country code (e.g., "US").</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; } = default!;
}