namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/sweep/list</c></para>
/// </summary>
public record TransferSweepListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("sweeps")]
	public IReadOnlyList<Entity.TransferSweep> Sweeps { get; init; } = default!;

}
