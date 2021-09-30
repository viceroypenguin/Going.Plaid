namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/list</c></para>
/// </summary>
public record TransferListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("transfers")]
	public IReadOnlyList<Entity.Transfer> Transfers { get; init; } = default!;
}