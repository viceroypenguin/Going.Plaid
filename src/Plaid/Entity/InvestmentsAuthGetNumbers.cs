namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for transferring holdings to an investments account.</para>
/// </summary>
public record InvestmentsAuthGetNumbers
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("acats")]
	public IReadOnlyList<Entity.NumbersACATS>? Acats { get; init; } = default!;
}