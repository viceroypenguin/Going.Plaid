namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of objects that define specific parties to a deal. This includes the direct participating parties, such as borrower and seller and the indirect parties such as the credit report provider.</para>
/// </summary>
public record CreditFreddieMacParties
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("PARTY")]
	public IReadOnlyList<Entity.CreditFreddieMacParty> Party { get; init; } = default!;
}