namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identity Match scores for one account.</para>
/// </summary>
public record IdentityMatchListAttemptScore
{
	/// <summary>
	/// <para>Plaid account ID for the account that was scored.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Score found by matching name provided by the API with the name on the account at the financial institution. If the account contains multiple owners, the maximum match score is filled.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public Entity.NameMatchScore LegalName { get; init; } = default!;

	/// <summary>
	/// <para>Score found by matching phone number provided by the API with the phone number on the account at the financial institution. 100 is a perfect match and 0 is a no match. If the account contains multiple owners, the maximum match score is filled.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public Entity.PhoneNumberMatchScore PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>Score found by matching email provided by the API with the email on the account at the financial institution. 100 is a perfect match and 0 is a no match. If the account contains multiple owners, the maximum match score is filled.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public Entity.EmailAddressMatchScore EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>Score found by matching address provided by the API with the address on the account at the financial institution. The score can range from 0 to 100 where 100 is a perfect match and 0 is a no match. If the account contains multiple owners, the maximum match score is filled.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.AddressMatchScore Address { get; init; } = default!;

}
