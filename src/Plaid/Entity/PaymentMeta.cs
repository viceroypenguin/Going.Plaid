namespace Going.Plaid.Entity;

/// <summary>
/// <para>Transaction information specific to inter-bank transfers. If the transaction was not an inter-bank transfer, all fields will be <c>null</c>.</para>
/// <para>If the <c>transactions</c> object was returned by a Transactions endpoint such as <c>/transactions/sync or </c>/transactions/get<c>, the </c>payment_meta<c> key will always appear, but no data elements are guaranteed. If the </c>transactions<c> object was returned by an Assets endpoint such as </c>/asset_report/get/<c> or </c>/asset_report/pdf/get`, this field will only appear in an Asset Report with Insights.</para>
/// </summary>
public record PaymentMeta
{
	/// <summary>
	/// <para>The transaction reference number supplied by the financial institution.</para>
	/// </summary>
	[JsonPropertyName("reference_number")]
	public string? ReferenceNumber { get; init; } = default!;

	/// <summary>
	/// <para>The ACH PPD ID for the payer.</para>
	/// </summary>
	[JsonPropertyName("ppd_id")]
	public string? PpdId { get; init; } = default!;

	/// <summary>
	/// <para>For transfers, the party that is receiving the transaction.</para>
	/// </summary>
	[JsonPropertyName("payee")]
	public string? Payee { get; init; } = default!;

	/// <summary>
	/// <para>The party initiating a wire transfer. Will be <c>null</c> if the transaction is not a wire transfer.</para>
	/// </summary>
	[JsonPropertyName("by_order_of")]
	public string? ByOrderOf { get; init; } = default!;

	/// <summary>
	/// <para>For transfers, the party that is paying the transaction.</para>
	/// </summary>
	[JsonPropertyName("payer")]
	public string? Payer { get; init; } = default!;

	/// <summary>
	/// <para>The type of transfer, e.g. 'ACH'</para>
	/// </summary>
	[JsonPropertyName("payment_method")]
	public string? PaymentMethod { get; init; } = default!;

	/// <summary>
	/// <para>The name of the payment processor</para>
	/// </summary>
	[JsonPropertyName("payment_processor")]
	public string? PaymentProcessor { get; init; } = default!;

	/// <summary>
	/// <para>The payer-supplied description of the transfer.</para>
	/// </summary>
	[JsonPropertyName("reason")]
	public string? Reason { get; init; } = default!;
}