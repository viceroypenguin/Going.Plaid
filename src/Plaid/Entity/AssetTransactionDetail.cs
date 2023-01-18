namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record AssetTransactionDetail
{
	/// <summary>
	/// <para>A vendor created unique Identifier.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionUniqueIdentifier")]
	public string Assettransactionuniqueidentifier { get; init; } = default!;

	/// <summary>
	/// <para>Asset Transaction Amount.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionAmount")]
	public decimal Assettransactionamount { get; init; } = default!;

	/// <summary>
	/// <para>Asset Transaction Date.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionDate")]
	public DateOnly Assettransactiondate { get; init; } = default!;

	/// <summary>
	/// <para>Asset Transaction Post Date.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionPostDate")]
	public DateOnly Assettransactionpostdate { get; init; } = default!;

	/// <summary>
	/// <para>Asset Transaction Type.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionType")]
	public Entity.AssetTransactionType Assettransactiontype { get; init; } = default!;

	/// <summary>
	/// <para>Populate with who did the transaction.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionPaidByName")]
	public string? Assettransactionpaidbyname { get; init; } = default!;

	/// <summary>
	/// <para>FI Provided - examples are atm, cash, check, credit, debit, deposit, directDebit, directDeposit, dividend, fee, interest, other, payment, pointOfSale, repeatPayment, serviceCharge, transfer.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionTypeAdditionalDescription")]
	public string? Assettransactiontypeadditionaldescription { get; init; } = default!;

	/// <summary>
	/// <para>Asset Transaction Category Type Enumerated derived by Vendor.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionCategoryType")]
	public Entity.AssetTransactionCategoryType? Assettransactioncategorytype { get; init; } = default!;

	/// <summary>
	/// <para>FI provided Transaction Identifier.</para>
	/// </summary>
	[JsonPropertyName("FinancialInstitutionTransactionIdentifier")]
	public string? Financialinstitutiontransactionidentifier { get; init; } = default!;
}