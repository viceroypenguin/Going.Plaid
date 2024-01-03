namespace Going.Plaid.Entity;

/// <summary>
/// <para>An institution object. If the Item was created via Same-Day micro-deposit verification, will be <c>null</c>.</para>
/// </summary>
public record LinkSessionSuccessMetadataInstitution
{
	/// <summary>
	/// <para>The full institution name, such as <c>'Wells Fargo'</c></para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid institution identifier</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

}
