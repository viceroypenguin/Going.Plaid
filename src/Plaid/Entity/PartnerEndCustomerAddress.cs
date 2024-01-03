namespace Going.Plaid.Entity;

/// <summary>
/// <para>The end customer's address.</para>
/// </summary>
public class PartnerEndCustomerAddress
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("street")]
	public string? Street { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>ISO-3166-1 alpha-2 country code standard.</para>
	/// </summary>
	[JsonPropertyName("country_code")]
	public string? CountryCode { get; set; } = default!;

}
