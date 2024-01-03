namespace Going.Plaid.Entity;

/// <summary>
/// <para>Phone number information associated with the entity screening hit</para>
/// </summary>
public record EntityScreeningHitPhoneNumbers
{
	/// <summary>
	/// <para>An enum indicating whether a phone number is a phone line or a fax line.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.PhoneType Type { get; init; } = default!;

	/// <summary>
	/// <para>A phone number in E.164 format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string PhoneNumber { get; init; } = default!;

}
