namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying values for <c>phone</c> attributes of risk check.</para>
/// </summary>
public record RiskCheckPhone
{
	/// <summary>
	/// <para>A list of online services where this phone number has been detected to have accounts or other activity.</para>
	/// </summary>
	[JsonPropertyName("linked_services")]
	public IReadOnlyList<Entity.RiskCheckLinkedService> LinkedServices { get; init; } = default!;

}
