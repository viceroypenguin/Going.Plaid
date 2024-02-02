namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object for <c>/credit/payroll_income/get</c> request options.</para>
/// </summary>
public class CreditPayrollIncomeGetRequestOptions
{
	/// <summary>
	/// <para>An array of <c>item_id</c>s whose payroll information is returned. Each <c>item_id</c> should uniquely identify a payroll income item. If this field is not provided, all <c>item_id</c>s associated with the <c>user_token</c> will returned in the response.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

}
