namespace Going.Plaid.Entity;

/// <summary>
/// <para>The end customer details for the newly-created customer client.</para>
/// </summary>
public record PartnerEndCustomerClient
{
	/// <summary>
	/// <para>Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.</para>
	/// </summary>
	[JsonPropertyName("client_id")]
	public string ClientId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("company_name")]
	public string CompanyName { get; init; } = default!;
}