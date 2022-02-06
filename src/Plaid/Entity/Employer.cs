namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data about the employer.</para>
/// </summary>
public record Employer
{
	/// <summary>
	/// <para>Plaid's unique identifier for the employer.</para>
	/// </summary>
	[JsonPropertyName("employer_id")]
	public string EmployerId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the employer</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>Data about the components comprising an address.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.AddressData? Address { get; init; } = default!;

	/// <summary>
	/// <para>A number from 0 to 1 indicating Plaid's level of confidence in the pairing between the employer and the institution (not yet implemented).</para>
	/// </summary>
	[JsonPropertyName("confidence_score")]
	public decimal ConfidenceScore { get; init; } = default!;
}