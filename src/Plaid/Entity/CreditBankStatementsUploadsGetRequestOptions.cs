namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object for <c>/credit/bank_statements/uploads/get</c> request options.</para>
/// </summary>
public class CreditBankStatementsUploadsGetRequestOptions
{
	/// <summary>
	/// <para>An array of <c>item_id</c>s whose bank statements information is returned. Each <c>item_id</c> should uniquely identify a bank statements uploaded item. If this field is not provided, all <c>item_id</c>s associated with the <c>user_token</c> will returned in the response.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

}
