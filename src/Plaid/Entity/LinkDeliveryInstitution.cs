namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information related to the financial institution.</para>
/// </summary>
public record LinkDeliveryInstitution
{
	/// <summary>
	/// <para>The full institution name, such as 'Wells Fargo'</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid institution identifier</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;
}