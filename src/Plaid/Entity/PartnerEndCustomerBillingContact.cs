namespace Going.Plaid.Entity;

/// <summary>
/// <para>The billing contact for the end customer. Defaults to partner's technical contact if omitted.</para>
/// </summary>
public class PartnerEndCustomerBillingContact
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("given_name")]
	public string GivenName { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("family_name")]
	public string FamilyName { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("email")]
	public string Email { get; set; } = default!;
}