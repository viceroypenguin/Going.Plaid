namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/originator/get</c></para>
/// </summary>
public record TransferOriginatorGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Originator and their status.</para>
	/// </summary>
	[JsonPropertyName("originator")]
	public Entity.Originator Originator { get; init; } = default!;

}
