namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/questionnaire/create</c></para>
/// </summary>
public partial class TransferQuestionnaireCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Client ID of the end customer.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>URL the end customer will be redirected to after completing questions in Plaid-hosted onboarding flow.</para>
	/// </summary>
	[JsonPropertyName("redirect_uri")]
	public string RedirectUri { get; set; } = default!;

	/// <summary>
	/// <para>Requested disbursement (i.e. sending money) limits for the end customer.</para>
	/// </summary>
	[JsonPropertyName("disbursement_limits")]
	public Entity.DisbursementLimits DisbursementLimits { get; set; } = default!;

	/// <summary>
	/// <para>Requested payment (i.e. receiving money) limits for the end customer.</para>
	/// </summary>
	[JsonPropertyName("payment_limits")]
	public Entity.PaymentLimits PaymentLimits { get; set; } = default!;

	/// <summary>
	/// <para>Best guess frequency of transactions of the end customer.</para>
	/// </summary>
	[JsonPropertyName("transaction_frequency")]
	public Entity.TransactionFrequency TransactionFrequency { get; set; } = default!;
}