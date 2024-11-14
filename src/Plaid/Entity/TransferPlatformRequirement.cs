namespace Going.Plaid.Entity;

/// <summary>
/// <para>A piece of information that is outstanding for the scaled platform onboarding process.</para>
/// </summary>
public record TransferPlatformRequirement
{
	/// <summary>
	/// <para>The type of requirement.</para>
	/// </summary>
	[JsonPropertyName("requirement_type")]
	public string? RequirementType { get; init; } = default!;

	/// <summary>
	/// <para>UUID of the person associated with the requirement. Only present for individual-scoped requirements.</para>
	/// </summary>
	[JsonPropertyName("person_id")]
	public string? PersonId { get; init; } = default!;

}
