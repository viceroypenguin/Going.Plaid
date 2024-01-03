namespace Going.Plaid.Entity;

/// <summary>
/// <para>ConsumerReportUserIdentity defines the user identity data collected for consumer report purpose. This field is required to be set if you later use the created user for consumer report purpose.</para>
/// </summary>
public class ConsumerReportUserIdentity
{
	/// <summary>
	/// <para>The user's first name</para>
	/// </summary>
	[JsonPropertyName("first_name")]
	public string FirstName { get; set; } = default!;

	/// <summary>
	/// <para>The user's last name</para>
	/// </summary>
	[JsonPropertyName("last_name")]
	public string LastName { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone numbers. The format of phone number will be validated and for better normalization, it is expected to be in E.164 format +{countrycode}{number}, for example <c>+14151234567</c>.</para>
	/// </summary>
	[JsonPropertyName("phone_numbers")]
	public IReadOnlyList<string> PhoneNumbers { get; set; } = default!;

	/// <summary>
	/// <para>The user's emails</para>
	/// </summary>
	[JsonPropertyName("emails")]
	public IReadOnlyList<string> Emails { get; set; } = default!;

	/// <summary>
	/// <para>Data about the components comprising an address.</para>
	/// </summary>
	[JsonPropertyName("primary_address")]
	public Entity.AddressData PrimaryAddress { get; set; } = default!;

}
