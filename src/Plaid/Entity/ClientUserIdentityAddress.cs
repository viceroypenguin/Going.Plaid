namespace Going.Plaid.Entity;

/// <summary>
/// <para>User address information.</para>
/// </summary>
public class ClientUserIdentityAddress
{
	/// <summary>
	/// <para>First line of street address.</para>
	/// </summary>
	[JsonPropertyName("street_1")]
	public string Street1 { get; set; } = default!;

	/// <summary>
	/// <para>Second line of street address.</para>
	/// </summary>
	[JsonPropertyName("street_2")]
	public string? Street2 { get; set; } = default!;

	/// <summary>
	/// <para>City name.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; } = default!;

	/// <summary>
	/// <para>State, province or region.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; set; } = default!;

	/// <summary>
	/// <para>Country code.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; } = default!;

	/// <summary>
	/// <para>Postal or ZIP code.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>Indicates whether this is the primary address for the User.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public bool Primary { get; set; } = default!;

}
