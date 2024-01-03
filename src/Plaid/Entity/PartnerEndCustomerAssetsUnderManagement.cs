namespace Going.Plaid.Entity;

/// <summary>
/// <para>Assets under management for the given end customer. Required for end customers with monthly service commitments.</para>
/// </summary>
public class PartnerEndCustomerAssetsUnderManagement
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; set; } = default!;

}
