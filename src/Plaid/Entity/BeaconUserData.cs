namespace Going.Plaid.Entity;

/// <summary>
/// <para>A Beacon User's data and resulting analysis when checked against duplicate records and the Beacon Fraud Network.</para>
/// </summary>
public record BeaconUserData
{
	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly DateOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>The full name for a given Beacon User.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.BeaconUserName Name { get; init; } = default!;

	/// <summary>
	/// <para>Even if an address has been collected, some fields may be null depending on the region's addressing system. For example:</para>
	/// <para>Addresses from the United Kingdom will not include a region</para>
	/// <para>Addresses from Hong Kong will not include a postal code</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.BeaconUserAddress Address { get; init; } = default!;

	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <a href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</a>.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>A phone number in E.164 format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>The ID number associated with a Beacon User.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.BeaconUserIDNumber? IdNumber { get; init; } = default!;

	/// <summary>
	/// <para>An IPv4 or IPV6 address.</para>
	/// </summary>
	[JsonPropertyName("ip_address")]
	public string? IpAddress { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("depository_accounts")]
	public IReadOnlyList<Entity.BeaconUserDepositoryAccount> DepositoryAccounts { get; init; } = default!;

}
