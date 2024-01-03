namespace Going.Plaid.Entity;

/// <summary>
/// <para>The legal name and other information for the account holder.</para>
/// </summary>
public record TransferUserInResponse
{
	/// <summary>
	/// <para>The user's legal name.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; init; } = default!;

	/// <summary>
	/// <para>The user's phone number.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>The user's email address.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>The address associated with the account holder.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.TransferUserAddressInResponse? Address { get; init; } = default!;

}
