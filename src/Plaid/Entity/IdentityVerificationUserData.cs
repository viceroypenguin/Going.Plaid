namespace Going.Plaid.Entity;

/// <summary>
/// <para>The identity data that was either collected from the user or provided via API in order to perform an Identity Verification.</para>
/// </summary>
public record IdentityVerificationUserData
{
	/// <summary>
	/// <para>A valid phone number in E.164 format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>An IPv4 or IPV6 address.</para>
	/// </summary>
	[JsonPropertyName("ip_address")]
	public string? IpAddress { get; init; } = default!;

	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>The full name provided by the user. If the user has not submitted their name, this field will be null. Otherwise, both fields are guaranteed to be filled.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.IdentityVerificationResponseUserName? Name { get; init; } = default!;

	/// <summary>
	/// <para>Even if an address has been collected, some fields may be null depending on the region's addressing system. For example:</para>
	/// <para>Addresses from the United Kingdom will not include a region</para>
	/// <para>Addresses from Hong Kong will not include postal code</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.IdentityVerificationUserAddress? Address { get; init; } = default!;

	/// <summary>
	/// <para>ID number submitted by the user, currently used only for the Identity Verification product. If the user has not submitted this data yet, this field will be <c>null</c>. Otherwise, both fields are guaranteed to be filled.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.UserIDNumber? IdNumber { get; init; } = default!;

}
