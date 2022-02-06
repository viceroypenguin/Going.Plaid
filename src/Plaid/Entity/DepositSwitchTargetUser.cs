namespace Going.Plaid.Entity;

/// <summary>
/// <para>The deposit switch target user</para>
/// </summary>
public class DepositSwitchTargetUser
{
	/// <summary>
	/// <para>The given name (first name) of the user.</para>
	/// </summary>
	[JsonPropertyName("given_name")]
	public string GivenName { get; set; } = default!;

	/// <summary>
	/// <para>The family name (last name) of the user.</para>
	/// </summary>
	[JsonPropertyName("family_name")]
	public string FamilyName { get; set; } = default!;

	/// <summary>
	/// <para>The phone number of the user. The endpoint can accept a variety of phone number formats, including E.164.</para>
	/// </summary>
	[JsonPropertyName("phone")]
	public string Phone { get; set; } = default!;

	/// <summary>
	/// <para>The email address of the user.</para>
	/// </summary>
	[JsonPropertyName("email")]
	public string Email { get; set; } = default!;

	/// <summary>
	/// <para>The user's address.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.DepositSwitchAddressData Address { get; set; } = default!;

	/// <summary>
	/// <para>The taxpayer ID of the user, generally their SSN, EIN, or TIN.</para>
	/// </summary>
	[JsonPropertyName("tax_payer_id")]
	public string TaxPayerId { get; set; } = default!;
}