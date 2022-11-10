namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/originator/list</c></para>
/// </summary>
public record TransferOriginatorListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("originators")]
	public IReadOnlyList<Entity.Originator> Originators { get; init; } = default!;
}