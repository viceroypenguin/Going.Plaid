namespace Going.Plaid.Entity;

/// <summary>
/// <para>The list of use cases associated with a given permissible purpose.</para>
/// </summary>
public class PartnerEndCustomerCRAUseCases
{
	/// <summary>
	/// <para>List of use cases for the given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("use_cases")]
	public IReadOnlyList<Entity.PartnerEndCustomerCRAUseCase>? UseCases { get; set; } = default!;

}
