namespace Going.Plaid.Entity;

/// <summary>
/// <para>A subset of a Beacon User's data which is used to patch the existing identity data associated with a Beacon User. At least one field must be provided,.</para>
/// </summary>
public class BeaconUserUpdateRequestData
{
	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; set; } = default!;

	/// <summary>
	/// <para>The full name for a given Beacon User.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.BeaconUserName? Name { get; set; } = default!;

	/// <summary>
	/// <para>Home address for the associated user. For more context on this field, see <a href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#input-validation-by-country">Input Validation by Country</a>.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.BeaconUserRequestAddress? Address { get; set; } = default!;

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
	/// <para>The ID number associated with a Beacon User.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.BeaconUserIDNumber? IdNumber { get; set; } = default!;

	/// <summary>
	/// <para>An IPv4 or IPV6 address.</para>
	/// </summary>
	[JsonPropertyName("ip_address")]
	public string? IpAddress { get; set; } = default!;

}
