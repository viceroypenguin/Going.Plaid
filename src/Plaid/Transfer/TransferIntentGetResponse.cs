namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/intent/get</c></para>
/// </summary>
public record TransferIntentGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a transfer intent within Transfer UI.</para>
	/// </summary>
	[JsonPropertyName("transfer_intent")]
	public Entity.TransferIntentGet TransferIntent { get; init; } = default!;

}
