namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
/// </summary>
public class TransactionsRecurringGetRequestOptions
{
	/// <summary>
	/// <para>Personal finance categories are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category")]
	public bool? IncludePersonalFinanceCategory { get; set; } = default!;
}