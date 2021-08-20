namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTokenCreateRequest defines the request schema for <c>/processor/token/create</c></para>
/// </summary>
public class ProcessorTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>account_id</c> value obtained from the <c>onSuccess</c> callback in Link</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>The processor you are integrating with.</para>
	/// </summary>
	[JsonPropertyName("processor")]
	public Entity.ProcessorTokenCreateRequestProcessorEnum Processor { get; set; } = default!;
}