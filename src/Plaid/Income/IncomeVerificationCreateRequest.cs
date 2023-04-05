namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationCreateRequest defines the request schema for <c>/income/verification/create</c></para>
/// </summary>
public partial class IncomeVerificationCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The URL endpoint to which Plaid should send webhooks related to the progress of the income verification process.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The ID of a precheck created with <c>/income/verification/precheck</c>. Will be used to improve conversion of the income verification flow.</para>
	/// </summary>
	[JsonPropertyName("precheck_id")]
	public string? PrecheckId { get; set; } = default!;

	/// <summary>
	/// <para>Optional arguments for <c>/income/verification/create</c></para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.IncomeVerificationCreateRequestOptions? Options { get; set; } = default!;
}