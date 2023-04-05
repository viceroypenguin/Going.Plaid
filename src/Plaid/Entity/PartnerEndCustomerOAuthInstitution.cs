namespace Going.Plaid.Entity;

/// <summary>
/// <para>The OAuth registration information for an institution.</para>
/// </summary>
public record PartnerEndCustomerOAuthInstitution
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>Registration statuses by environment.</para>
	/// </summary>
	[JsonPropertyName("environments")]
	public Entity.PartnerEndCustomerOAuthInstitutionEnvironments? Environments { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the end customer's application was approved by the institution, or an empty string if their application has not yet been approved.</para>
	/// </summary>
	[JsonPropertyName("production_enablement_date")]
	public string? ProductionEnablementDate { get; init; } = default!;

	/// <summary>
	/// <para>The date on which non-OAuth Item adds will no longer be supported for this institution, or an empty string if no such date has been set by the institution.</para>
	/// </summary>
	[JsonPropertyName("classic_disablement_date")]
	public string? ClassicDisablementDate { get; init; } = default!;
}