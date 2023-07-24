namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTokenWebhookUpdateRequest defines the request schema for <c>/processor/token/webhook/update</c></para>
/// </summary>
public partial class ProcessorTokenWebhookUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

	/// <summary>
	/// <para>The new webhook URL to associate with the processor token. To remove a webhook from a processor token, set to <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;
}