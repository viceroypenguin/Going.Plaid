namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with Bank Employment. This field is required if <c>employment</c> is included in the <c>products</c> array and <c>bank</c> is specified in <c>employment_source_types</c>.</para>
/// </summary>
public class LinkTokenCreateRequestEmploymentBankIncome
{
	/// <summary>
	/// <para>The number of days of data to request for the Bank Employment product.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

}
