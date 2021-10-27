namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorStripeBankAccountTokenCreateRequest defines the request schema for <c>/processor/stripe/bank_account/create</c></para>
/// </summary>
public partial class ProcessorStripeBankAccountTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>account_id</c> value obtained from the <c>onSuccess</c> callback in Link</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;
}