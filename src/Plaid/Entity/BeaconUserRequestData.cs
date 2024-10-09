namespace Going.Plaid.Entity;

/// <summary>
/// <para>A Beacon User's data which is used to check against duplicate records and the Beacon Fraud Network.</para>
/// <para>In order to create a Beacon User, in addition to the <c>name</c>, _either_ the <c>date_of_birth</c> _or_ the <c>depository_accounts</c> field must be provided.</para>
/// </summary>
public class BeaconUserRequestData
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
	public Entity.BeaconUserName Name { get; set; } = default!;

	/// <summary>
	/// <para>Home address for the associated user. For more context on this field, see <a href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#input-validation-by-country">Input Validation by Country</a>.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.BeaconUserRequestAddress? Address { get; set; } = default!;

	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <a href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</a>.</para>
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

	/// <summary>
	/// <para>Provide a list of bank accounts that are associated with this Beacon User. These accounts will be scanned across the Beacon Network and used to find duplicate records.</para>
	/// <para>Note: These accounts will not have Bank Account Insights. To receive Bank Account Insights please supply <c>access_tokens</c>.</para>
	/// </summary>
	[JsonPropertyName("depository_accounts")]
	public IReadOnlyList<Entity.BeaconUserRequestDepositoryAccount>? DepositoryAccounts { get; set; } = default!;

}
