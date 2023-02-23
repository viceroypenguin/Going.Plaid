namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorSignalReturnReportRequest defines the request schema for <c>/processor/signal/return/report</c></para>
/// </summary>
public partial class ProcessorSignalReturnReportRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-environment-identifier</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

	/// <summary>
	/// <para>Must be the same as the <c>client_transaction_id</c> supplied when calling <c>/processor/signal/evaluate</c></para>
	/// </summary>
	[JsonPropertyName("client_transaction_id")]
	public string ClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para>Must be a valid ACH return code (e.g. "R01")</para>
	/// <para>If formatted incorrectly, this will result in an <a href="https://plaid.com/docs/errors/invalid-request/#invalid_field"><c>INVALID_FIELD</c></a> error.</para>
	/// </summary>
	[JsonPropertyName("return_code")]
	public string ReturnCode { get; set; } = default!;

	/// <summary>
	/// <para>Date and time when you receive the returns from your payment processors, in ISO 8601 format (<c>YYYY-MM-DDTHH:mm:ssZ</c>).</para>
	/// </summary>
	[JsonPropertyName("returned_at")]
	public DateTimeOffset? ReturnedAt { get; set; } = default!;
}