namespace Going.Plaid.Entity;

/// <summary>
/// <para>The identity fields associated with a user. For a user to be eligible for a Plaid Check Consumer Report, all fields are required except <c>id_number</c>. Providing a partial SSN is strongly recommended, and improves the accuracy of matching user records during compliance processes such as file disclosure, dispute, or security freeze requests. If creating a report that will be shared with GSEs such as Fannie or Freddie, a full Social Security Number must be provided via the <c>id_number</c> field.</para>
/// </summary>
public class ClientUserIdentity
{
	/// <summary>
	/// <para>User name information.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.ClientUserIdentityName? Name { get; set; } = default!;

	/// <summary>
	/// <para>The user's date of birth, to be provided in the format "yyyy-mm-dd".</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; set; } = default!;

	/// <summary>
	/// <para>The user's emails.</para>
	/// </summary>
	[JsonPropertyName("emails")]
	public IReadOnlyList<Entity.ClientUserIdentityEmail>? Emails { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone numbers, in E.164 format: +{countrycode}{number}. For example: "+14157452130". Phone numbers provided in other formats will be parsed on a best-effort basis. Phone number input is validated against valid number ranges; number strings that do not match a real-world phone numbering scheme may cause the request to fail, even in the Sandbox test environment.</para>
	/// </summary>
	[JsonPropertyName("phone_numbers")]
	public IReadOnlyList<Entity.ClientUserIdentityPhoneNumber>? PhoneNumbers { get; set; } = default!;

	/// <summary>
	/// <para>The user's addresses.</para>
	/// </summary>
	[JsonPropertyName("addresses")]
	public IReadOnlyList<Entity.ClientUserIdentityAddress>? Addresses { get; set; } = default!;

	/// <summary>
	/// <para>The user's ID numbers.</para>
	/// </summary>
	[JsonPropertyName("id_numbers")]
	public IReadOnlyList<Entity.UserIDNumber>? IdNumbers { get; set; } = default!;

}
