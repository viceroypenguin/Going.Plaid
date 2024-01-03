namespace Going.Plaid.Entity;

/// <summary>
/// <para>The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.</para>
/// </summary>
public class BankTransferFailure
{
	/// <summary>
	/// <para>The ACH return code, e.g. <c>R01</c>.  A return code will be provided if and only if the transfer status is <c>reversed</c>. For a full listing of ACH return codes, see <a href="https://plaid.com/docs/errors/bank-transfers/#ach-return-codes">Bank Transfers errors</a>.</para>
	/// </summary>
	[JsonPropertyName("ach_return_code")]
	public string? AchReturnCode { get; set; } = default!;

	/// <summary>
	/// <para>A human-readable description of the reason for the failure or reversal.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; } = default!;

}
