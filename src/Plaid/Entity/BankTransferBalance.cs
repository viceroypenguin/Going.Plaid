namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the balance of a bank transfer</para>
/// </summary>
public record BankTransferBalance
{
	/// <summary>
	/// <para>The total available balance - the sum of all successful debit transfer amounts minus all credit transfer amounts.</para>
	/// </summary>
	[JsonPropertyName("available")]
	public string Available { get; init; } = default!;

	/// <summary>
	/// <para>The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.</para>
	/// </summary>
	[JsonPropertyName("transactable")]
	public string Transactable { get; init; } = default!;

}
