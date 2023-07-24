namespace Going.Plaid.Entity;

/// <summary>
/// <para>User information collected outside of Link, most likely via your own onboarding process.</para>
/// <para>Each of the following identity fields are optional:</para>
/// <para><c>email_address</c></para>
/// <para><c>phone_number</c></para>
/// <para><c>date_of_birth</c></para>
/// <para><c>name</c></para>
/// <para><c>address</c></para>
/// <para><c>id_number</c></para>
/// <para>Specifically, these fields are optional in that they can either be fully provided (satisfying every required field in their subschema) or omitted from the request entirely by not providing the key or value.</para>
/// <para>Providing these fields via the API will result in Link skipping the data collection process for the associated user. All verification steps enabled in the associated Identity Verification Template will still be run. Verification steps will either be run immediately, or once the user completes the <c>accept_tos</c> step, depending on the value provided to the <c>gave_consent</c> field.</para>
/// </summary>
public class IdentityVerificationRequestUser
{
	/// <summary>
	/// <para>A valid email address.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>A phone number in E.164 format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; set; } = default!;

	/// <summary>
	/// <para>You can use this field to pre-populate the user's legal name; if it is provided here, they will not be prompted to enter their name in the identity verification attempt.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.IdentityVerificationRequestUserName? Name { get; set; } = default!;

	/// <summary>
	/// <para>Home address for the user. For more context on this field, see <a href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#input-validation-by-country">Input Validation by Country</a>.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.UserAddress? Address { get; set; } = default!;

	/// <summary>
	/// <para>ID number submitted by the user, currently used only for the Identity Verification product. If the user has not submitted this data yet, this field will be <c>null</c>. Otherwise, both fields are guaranteed to be filled.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.UserIDNumber? IdNumber { get; set; } = default!;
}