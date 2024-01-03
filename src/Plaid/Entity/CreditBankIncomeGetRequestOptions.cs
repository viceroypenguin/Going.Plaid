namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object for <c>/credit/bank_income/get</c> request options.</para>
/// </summary>
public class CreditBankIncomeGetRequestOptions
{
	/// <summary>
	/// <para>How many Bank Income Reports should be fetched. Multiple reports may be available if the report has been re-created or refreshed. If more than one report is available, the most recent reports will be returned first.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

}
