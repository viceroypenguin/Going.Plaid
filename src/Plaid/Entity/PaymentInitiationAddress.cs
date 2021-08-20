namespace Going.Plaid.Entity;

/// <summary>
/// <para>The optional address of the payment recipient. This object is not currently required to make payments from UK institutions and should not be populated, though may be necessary for future European expansion.</para>
/// </summary>
public class PaymentInitiationAddress
{
	/// <summary>
	/// <para>An array of length 1-2 representing the street address where the recipient is located. Maximum of 70 characters.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public IReadOnlyList<string> Street { get; set; } = default!;

	/// <summary>
	/// <para>The city where the recipient is located. Maximum of 35 characters.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; } = default!;

	/// <summary>
	/// <para>The postal code where the recipient is located. Maximum of 16 characters.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>The ISO 3166-1 alpha-2 country code where the recipient is located.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; } = default!;
}