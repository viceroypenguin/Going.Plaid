namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/get</c></para>
/// </summary>
public record TransferGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a transfer within the Transfers API.</para>
	/// </summary>
	[JsonPropertyName("transfer")]
	public Entity.Transfer Transfer { get; init; } = default!;
}