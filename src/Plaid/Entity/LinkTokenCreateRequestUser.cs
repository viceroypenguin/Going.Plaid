namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object specifying information about the end user who will be linking their account. **Required** if <c>user_id</c> isn't included.</para>
/// </summary>
public class LinkTokenCreateRequestUser
{
	/// <summary>
	/// <para>A unique ID representing the end user. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>. It is currently used as a means of searching logs for the given user in the Plaid Dashboard.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>The user's full legal name, used for <a href="https://plaid.com/docs/auth/coverage/">micro-deposit based verification flows</a>. For a small number of customers on legacy flows, providing this field is required to enable micro-deposit-based flows. For all other customers, this field is optional. Providing the user's name in this field when using micro-deposit-based verification will streamline the end user experience, as the user will not be prompted to enter their name during the Link flow; Plaid will use the provided legal name instead.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string? LegalName { get; set; } = default!;

	/// <summary>
	/// <para>The user's full name. Optional if using the <a href="https://plaid.com/docs/api/products/identity-verification">Identity Verification</a> product; if not using Identity Verification, this field is not allowed. Users will not be asked for their name when this field is provided.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.LinkTokenCreateRequestUserNameObject? Name { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone number in <a href="https://en.wikipedia.org/wiki/E.164">E.164</a> format. If supplied, will be used when applicable to prefill phone number fields in Link for the <a href="https://plaid.com/docs/link/returning-user">returning user flow</a> and the <a href="https://plaid.com/docs/identity-verification">Identity Verification flow</a>. Phone number input is validated against valid number ranges; number strings that do not match a real-world phone numbering scheme may cause the request to fail, even in the Sandbox test environment.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; } = default!;

	/// <summary>
	/// <para>The date and time the phone number was verified in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDThh:mm:ssZ</c>). This was previously an optional field used in the <a href="https://plaid.com/docs/link/returning-user">returning user experience</a>. This field is no longer required to enable the returning user experience.</para>
	/// <para> Only pass a verification time for a phone number that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.</para>
	/// <para> Example: <c>2020-01-01T00:00:00Z</c></para>
	/// </summary>
	[JsonPropertyName("phone_number_verified_time")]
	[Obsolete]
	public DateTimeOffset? PhoneNumberVerifiedTime { get; set; } = default!;

	/// <summary>
	/// <para>The user's email address. Can be used to prefill Link fields when used with <a href="https://plaid.com/docs/identity-verification">Identity Verification</a>.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>The date and time the email address was verified in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDThh:mm:ssZ</c>). This was previously an optional field used in the <a href="https://plaid.com/docs/link/returning-user">returning user experience</a>. This field is no longer required to enable the returning user experience.</para>
	/// <para> Only pass a verification time for an email address that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.</para>
	/// <para> Example: <c>2020-01-01T00:00:00Z</c></para>
	/// </summary>
	[JsonPropertyName("email_address_verified_time")]
	[Obsolete]
	public DateTimeOffset? EmailAddressVerifiedTime { get; set; } = default!;

	/// <summary>
	/// <para>Deprecated and not currently used, use the <c>id_number</c> field instead.</para>
	/// </summary>
	[JsonPropertyName("ssn")]
	[Obsolete]
	public string? Ssn { get; set; } = default!;

	/// <summary>
	/// <para>To be provided in the format "yyyy-mm-dd". Can be used to prefill Link fields when used with Identity Verification.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; set; } = default!;

	/// <summary>
	/// <para>The user's address. Used only for Identity Verification and the Identity Match in Link workflows. If provided for Identity Verification, the user will not be shown fields to enter their address in the Identity Verification flow. If provided for Identity Match, the provided data will be used to match against the user's address. May be omitted, but if not omitted, all fields marked as required must be provided.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.LinkTokenCreateRequestUserAddressObject? Address { get; set; } = default!;

	/// <summary>
	/// <para>The user's ID number. Used only for Identity Verification. If provided, the user will not be shown fields to enter their ID number in the Identity Verification flow. May be omitted, but if not omitted, all fields marked as required must be provided.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.LinkTokenCreateRequestUserIdNumberObject? IdNumber { get; set; } = default!;

}
