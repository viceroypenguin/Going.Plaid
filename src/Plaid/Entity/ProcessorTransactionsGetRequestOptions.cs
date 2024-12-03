namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
/// </summary>
public class ProcessorTransactionsGetRequestOptions
{
	/// <summary>
	/// <para>The number of transactions to fetch.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to skip. The default value is 0.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; } = default!;

	/// <summary>
	/// <para>Include the raw unparsed transaction description from the financial institution.</para>
	/// </summary>
	[JsonPropertyName("include_original_description")]
	public bool? IncludeOriginalDescription { get; set; } = default!;

	/// <summary>
	/// <para>Personal finance categories are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category_beta")]
	[Obsolete]
	public bool? IncludePersonalFinanceCategoryBeta { get; set; } = default!;

	/// <summary>
	/// <para>Personal finance categories are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category")]
	[Obsolete]
	public bool? IncludePersonalFinanceCategory { get; set; } = default!;

	/// <summary>
	/// <para>Counterparties and extra merchant fields are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_logo_and_counterparty_beta")]
	[Obsolete]
	public bool? IncludeLogoAndCounterpartyBeta { get; set; } = default!;

}
