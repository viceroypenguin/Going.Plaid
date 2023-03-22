namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying values for <c>phone</c> attributes of risk check.</para>
/// </summary>
public record RiskCheckPhone
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("linked_services")]
	public IReadOnlyList<Entity.RiskCheckLinkedService> LinkedServices { get; init; } = default!;
}