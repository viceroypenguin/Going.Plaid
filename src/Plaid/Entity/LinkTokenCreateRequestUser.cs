namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object specifying information about the end user who will be linking their account.</para>
/// </summary>
public class LinkTokenCreateRequestUser
{
	/// <summary>
	/// <para>A unique ID representing the end user. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>. It is currently used as a means of searching logs for the given user in the Plaid Dashboard.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>The user's full legal name. This is an optional field used in the <a href="https://plaid.com/docs/link/returning-user">returning user experience</a> to associate Items to the user.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone number in <a href="https://en.wikipedia.org/wiki/E.164">E.164</a> format. This field is optional, but required to enable the <a href="https://plaid.com/docs/link/returning-user">returning user experience</a>.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string PhoneNumber { get; set; } = default!;

	/// <summary>
	/// <para>The date and time the phone number was verified in ISO 8601 format (<c>YYYY-MM-DDThh:mm:ssZ</c>). This field is optional, but required to enable any <a href="https://plaid.com/docs/link/returning-user">returning user experience</a>.</para>
	/// <para> Only pass a verification time for a phone number that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.</para>
	/// <para> Example: <c>2020-01-01T00:00:00Z</c></para>
	/// </summary>
	[JsonPropertyName("phone_number_verified_time")]
	public DateTimeOffset PhoneNumberVerifiedTime { get; set; } = default!;

	/// <summary>
	/// <para>The user's email address. This field is optional, but required to enable the <a href="https://plaid.com/docs/link/returning-user/#enabling-the-returning-user-experience">pre-authenticated returning user flow</a>.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>The date and time the email address was verified in ISO 8601 format (<c>YYYY-MM-DDThh:mm:ssZ</c>). This is an optional field used in the <a href="https://plaid.com/docs/link/returning-user">returning user experience</a>.</para>
	/// <para> Only pass a verification time for an email address that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.</para>
	/// <para> Example: <c>2020-01-01T00:00:00Z</c></para>
	/// </summary>
	[JsonPropertyName("email_address_verified_time")]
	public DateTimeOffset EmailAddressVerifiedTime { get; set; } = default!;

	/// <summary>
	/// <para>To be provided in the format "ddd-dd-dddd". This field is optional and will support not-yet-implemented functionality for new products.</para>
	/// </summary>
	[JsonPropertyName("ssn")]
	public string Ssn { get; set; } = default!;

	/// <summary>
	/// <para>To be provided in the format "yyyy-mm-dd". This field is optional and will support not-yet-implemented functionality for new products.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateTimeOffset DateOfBirth { get; set; } = default!;
}