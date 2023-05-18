namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/balance/get</c></para>
/// </summary>
public partial class TransferBalanceGetRequest : RequestBase
{
	/// <summary>
	/// <para>The type of balance.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferBalanceType Type { get; set; } = default!;
}