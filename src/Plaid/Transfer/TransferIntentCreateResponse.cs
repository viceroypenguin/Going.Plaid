namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/intent/create</c></para>
/// </summary>
public record TransferIntentCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a transfer intent within Transfer UI.</para>
	/// </summary>
	[JsonPropertyName("transfer_intent")]
	public Entity.TransferIntentCreate TransferIntent { get; init; } = default!;
}