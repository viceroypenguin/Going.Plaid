namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/create</c></para>
/// </summary>
public record TransferCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a transfer within the Transfers API.</para>
	/// </summary>
	[JsonPropertyName("transfer")]
	public Entity.Transfer Transfer { get; init; } = default!;

}
