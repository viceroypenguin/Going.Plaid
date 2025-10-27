namespace Going.Plaid.Entity;

/// <summary>
/// <para>Originator and their status.</para>
/// </summary>
public record Originator
{
	/// <summary>
	/// <para>Originator’s client ID.</para>
	/// </summary>
	[JsonPropertyName("client_id")]
	public string ClientId { get; init; } = default!;

	/// <summary>
	/// <para>Originator’s diligence status.</para>
	/// </summary>
	[JsonPropertyName("transfer_diligence_status")]
	public Entity.TransferDiligenceStatus TransferDiligenceStatus { get; init; } = default!;

	/// <summary>
	/// <para>The company name of the end customer.</para>
	/// </summary>
	[JsonPropertyName("company_name")]
	public string CompanyName { get; init; } = default!;

	/// <summary>
	/// <para>List of outstanding requirements that must be submitted before Plaid can approve the originator. Only populated when <c>transfer_diligence_status</c> is <c>more_information_required</c>.</para>
	/// </summary>
	[JsonPropertyName("outstanding_requirements")]
	public IReadOnlyList<Entity.TransferPlatformRequirement>? OutstandingRequirements { get; init; } = default!;

}
