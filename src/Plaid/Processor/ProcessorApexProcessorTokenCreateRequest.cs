namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorApexProcessorTokenCreateRequest defines the request schema for <c>/processor/apex/processor_token/create</c></para>
/// </summary>
public partial class ProcessorApexProcessorTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>account_id</c> value obtained from the <c>onSuccess</c> callback in Link</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;
}