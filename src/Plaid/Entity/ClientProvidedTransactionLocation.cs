namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of where a transaction took place.</para>
/// <para>Use this field to pass in structured location information you may have about your transactions. Providing location data is optional but can increase result quality. If you have unstructured location information, it may be appended to the <c>description</c> field.</para>
/// </summary>
public class ClientProvidedTransactionLocation
{
	/// <summary>
	/// <para>The country where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; } = default!;

	/// <summary>
	/// <para>The region or state where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; set; } = default!;

	/// <summary>
	/// <para>The city where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; } = default!;

	/// <summary>
	/// <para>The street address where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; } = default!;

	/// <summary>
	/// <para>The postal code where the transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; } = default!;
}