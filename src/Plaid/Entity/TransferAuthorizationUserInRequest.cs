namespace Going.Plaid.Entity;

/// <summary>
/// <para>The legal name and other information for the account holder. The <c>user.legal_name</c> field is required. Other fields are not currently used and are present to support planned future functionality.</para>
/// </summary>
public partial class TransferAuthorizationUserInRequest
{
	/// <summary>
	/// <para>The user's legal name. If the user is a business, provide the business name.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone number.</para>
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