namespace Going.Plaid.Entity;

/// <summary>
/// <para>Registration statuses by environment.</para>
/// </summary>
public record PartnerEndCustomerOAuthInstitutionEnvironments
{
	/// <summary>
	/// <para>The registration status for the end customer's application.</para>
	/// </summary>
	[JsonPropertyName("development")]
	public Entity.PartnerEndCustomerOAuthInstitutionApplicationStatus? Development { get; init; } = default!;

	/// <summary>
	/// <para>The registration status for the end customer's application.</para>
	/// </summary>
	[JsonPropertyName("production")]
	public Entity.PartnerEndCustomerOAuthInstitutionApplicationStatus? Production { get; init; } = default!;
}