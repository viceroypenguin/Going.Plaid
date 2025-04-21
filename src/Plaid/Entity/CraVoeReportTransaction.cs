namespace Going.Plaid.Entity;

/// <summary>
/// <para>A transaction on the VoE report. Note that this transaction differs from a Base Report transaction in that it will only be deposits, and the amounts will be omitted.</para>
/// </summary>
public record CraVoeReportTransaction
{
	/// <summary>
	/// <para>The ID of the account in which this transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The string returned by the financial institution to describe the transaction.</para>
	/// </summary>
	[JsonPropertyName("original_description")]
	public string OriginalDescription { get; init; } = default!;

	/// <summary>
	/// <para>For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted. Both dates are returned in an ISO 8601 format ( <c>YYYY-MM-DD</c> ).</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, identifies the transaction as pending or unsettled. Pending transaction details (name, type, amount, category ID) may change before they are settled.</para>
	/// </summary>
	[JsonPropertyName("pending")]
	public bool Pending { get; init; } = default!;

	/// <summary>
	/// <para>The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;

}
