namespace Going.Plaid.Entity;

/// <summary>
/// <para>User information that was autofilled. All this information should be confirmed by the user before using.</para>
/// </summary>
public record IdentityVerificationAutofillUserData
{
	/// <summary>
	/// <para>The full name provided by the user. If the user has not submitted their name, this field will be null. Otherwise, both fields are guaranteed to be filled.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.IdentityVerificationResponseUserName? Name { get; init; } = default!;

	/// <summary>
	/// <para>Even if an address has been autofilled, some fields may be null depending on the region's addressing system. For example:</para>
	/// <para>Addresses from the United Kingdom will not include a region</para>
	/// <para>Addresses from Hong Kong will not include postal code</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.IdentityVerificationAutofillAddress? Address { get; init; } = default!;

	/// <summary>
	/// <para>ID number submitted by the user, currently used only for the Identity Verification product. If the user has not submitted this data yet, this field will be <c>null</c>. Otherwise, both fields are guaranteed to be filled.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.UserIDNumber? IdNumber { get; init; } = default!;

}
