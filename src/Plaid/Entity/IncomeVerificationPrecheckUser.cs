namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the user whose eligibility is being evaluated.</para>
/// </summary>
public class IncomeVerificationPrecheckUser
{
	/// <summary>
	/// <para>The user's first name</para>
	/// </summary>
	[JsonPropertyName("first_name")]
	public string? FirstName { get; set; } = default!;

	/// <summary>
	/// <para>The user's last name</para>
	/// </summary>
	[JsonPropertyName("last_name")]
	public string? LastName { get; set; } = default!;

	/// <summary>
	/// <para>The user's email address</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>Data about the components comprising an address.</para>
	/// </summary>
	[JsonPropertyName("home_address")]
	public Entity.AddressData? HomeAddress { get; set; } = default!;
}