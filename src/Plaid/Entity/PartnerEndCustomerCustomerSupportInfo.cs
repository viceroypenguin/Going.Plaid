namespace Going.Plaid.Entity;

/// <summary>
/// <para>This information is public. Users of your app will see this information when managing connections between your app and their bank accounts in Plaid Portal. Defaults to partner's customer support info if omitted.</para>
/// </summary>
public class PartnerEndCustomerCustomerSupportInfo
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("email")]
	public string? Email { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("contact_url")]
	public string? ContactUrl { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("link_update_url")]
	public string? LinkUpdateUrl { get; set; } = default!;

}
