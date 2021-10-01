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
}