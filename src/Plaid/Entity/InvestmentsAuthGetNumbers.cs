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

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("aton")]
	public IReadOnlyList<Entity.NumbersATON>? Aton { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("retirement_401k")]
	public IReadOnlyList<Entity.NumbersRetirement401k>? Retirement401k { get; init; } = default!;

}
