namespace Going.Plaid.Auth;

/// <summary>
/// <para>AuthGetResponse defines the response schema for <c>/auth/get</c></para>
/// </summary>
public record AuthGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The <c>accounts</c> for which numbers are being retrieved.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.Account> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>An object containing identifying numbers used for making electronic transfers to and from the <c>accounts</c>. The identifying number type (ACH, EFT, IBAN, or BACS) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by any <c>accounts</c> for which data has been requested, the array for that type will be empty.</para>
	/// </summary>
	[JsonPropertyName("numbers")]
	public Entity.AuthGetNumbers Numbers { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

}
