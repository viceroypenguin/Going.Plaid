namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsRecurringGetResponse defines the response schema for <c>/transactions/recurring/get</c></para>
/// </summary>
public record TransactionsRecurringGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of depository transaction streams.</para>
	/// </summary>
	[JsonPropertyName("inflow_streams")]
	public IReadOnlyList<Entity.TransactionStream> InflowStreams { get; init; } = default!;

	/// <summary>
	/// <para>An array of expense transaction streams.</para>
	/// </summary>
	[JsonPropertyName("outflow_streams")]
	public IReadOnlyList<Entity.TransactionStream> OutflowStreams { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the last time transaction streams for the given account were updated on</para>
	/// </summary>
	[JsonPropertyName("updated_datetime")]
	public DateTimeOffset UpdatedDatetime { get; init; } = default!;

	/// <summary>
	/// <para>Optional parameter that specifies which version of the personal finance category taxonomy to return. The v2 taxonomy is defined <a href="https://docs.google.com/spreadsheets/d/e/2PACX-1vRUQR6BdYCwu7libfEUUA0U4TYfkyxpAUOSCj_unpv6OYCJMhIC0_PNrJnnki0At3LAG0PgT3aY7hRz/pubhtml">here</a>. The legacy v1 taxonomy is defined <a href="https://docs.google.com/spreadsheets/d/e/2PACX-1vQb96YxbnLdHbAROh1Dx7BaSpChnAIEKp1zZZFLBBpGbiLtPR3JTtxzvQ8mF4kU0StL8Y16WEpUd5P2/pubhtml">here</a>.</para>
	/// <para>If you enabled any Financial Insights products before October 2025 you will receive a default of <c>v1</c> taxonomy and may request <c>v2</c> by explicitly setting this field to <c>v2</c>.</para>
	/// <para>If you enabled any Financial Insights products on or after October 2025 you may only receive <c>v2</c> taxonomy.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category_version")]
	public string? PersonalFinanceCategoryVersion { get; init; } = default!;

}
