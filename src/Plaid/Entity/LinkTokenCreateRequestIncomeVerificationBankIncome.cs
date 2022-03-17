namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with Bank Income. This field is required if <c>income_verification</c> is included in the <c>products</c> array and <c>bank</c> is specified in <c>income_source_types</c>.</para>
/// </summary>
public class LinkTokenCreateRequestIncomeVerificationBankIncome
{
	/// <summary>
	/// <para>The number of days of data to request for the Bank Income product</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;
}