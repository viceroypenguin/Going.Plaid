namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the end user initiating the transaction (i.e., the account holder). When calling <c>/signal/evaluate</c> or <c>/signal/processor/evaluate</c>, this field is optional, but strongly recommended to increase the accuracy of Signal results.</para>
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
