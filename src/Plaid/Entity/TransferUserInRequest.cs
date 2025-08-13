namespace Going.Plaid.Entity;

/// <summary>
/// <para>The legal name and other information for the account holder.</para>
/// </summary>
public class TransferUserInRequest
{
	/// <summary>
	/// <para>The user's legal name.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone number. Phone number input may be validated against valid number ranges; number strings that do not match a real-world phone numbering scheme may cause the request to fail, even in the Sandbox test environment.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; } = default!;

	/// <summary>
	/// <para>The user's email address.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>The address associated with the account holder.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.TransferUserAddressInRequest? Address { get; set; } = default!;

}
