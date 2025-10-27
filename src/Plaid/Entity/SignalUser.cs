namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the end user initiating the transaction (i.e., the account holder). These fields are optional, but strongly recommended to increase the accuracy of results when using Signal Transaction Scores. When using a Balance-only ruleset, if the Signal Addendum has been signed, these fields are ignored; if the Addendum has not been signed, using these fields will result in an error.</para>
/// </summary>
public class SignalUser
{
	/// <summary>
	/// <para>The user's legal name</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.SignalPersonName? Name { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone number, in E.164 format: +{countrycode}{number}. For example: "+14151234567"</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; } = default!;

	/// <summary>
	/// <para>The user's email address.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>Data about the components comprising an address.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.AddressData? Address { get; set; } = default!;

}
