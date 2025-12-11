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
	/// 
	/// </summary>
	[JsonPropertyName("personal_finance_category_version")]
	public Entity.PersonalFinanceCategoryVersion? PersonalFinanceCategoryVersion { get; init; } = default!;

}
