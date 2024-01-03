namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details for an end customer.</para>
/// </summary>
public record PartnerEndCustomer
{
	/// <summary>
	/// <para>The <c>client_id</c> of the end customer.</para>
	/// </summary>
	[JsonPropertyName("client_id")]
	public string? ClientId { get; init; } = default!;

	/// <summary>
	/// <para>The company name associated with the end customer.</para>
	/// </summary>
	[JsonPropertyName("company_name")]
	public string? CompanyName { get; init; } = default!;

	/// <summary>
	/// <para>The status of the given end customer.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PartnerEndCustomerStatus? Status { get; init; } = default!;

}
