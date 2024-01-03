namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/balance/get</c></para>
/// </summary>
public record TransferBalanceGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Information about the balance held with Plaid.</para>
	/// </summary>
	[JsonPropertyName("balance")]
	public Entity.TransferBalance Balance { get; init; } = default!;

}
