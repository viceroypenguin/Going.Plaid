namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of details related to a fulfillment service or product in terms of request, process and result.</para>
/// </summary>
public record CreditFreddieMacService
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("VERIFICATION_OF_ASSET")]
	public IReadOnlyList<Entity.CreditFreddieMacVerificationOfAsset> VerificationOfAsset { get; init; } = default!;

	/// <summary>
	/// <para>A collection of STATUS containers.</para>
	/// </summary>
	[JsonPropertyName("STATUSES")]
	public Entity.Statuses Statuses { get; init; } = default!;
}