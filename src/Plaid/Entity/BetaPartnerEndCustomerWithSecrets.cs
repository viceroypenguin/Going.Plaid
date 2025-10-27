namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details for the newly created end customer, including secrets for Sandbox and Limited Production.</para>
/// </summary>
public record BetaPartnerEndCustomerWithSecrets
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

	/// <summary>
	/// <para>Mapping of product names to their current status.</para>
	/// </summary>
	[JsonPropertyName("product_statuses")]
	public Entity.PartnerEndCustomerProductStatuses? ProductStatuses { get; init; } = default!;

	/// <summary>
	/// <para>A list of fields that are still required to be submitted.</para>
	/// </summary>
	[JsonPropertyName("requirements_due")]
	public IReadOnlyList<Entity.PartnerEndCustomerRequirementDue>? RequirementsDue { get; init; } = default!;

	/// <summary>
	/// <para>The secrets for the newly created end customer.</para>
	/// </summary>
	[JsonPropertyName("secrets")]
	public Entity.PartnerEndCustomerSecrets? Secrets { get; init; } = default!;

}
