namespace Going.Plaid.Beacon;

/// <summary>
/// <para>BeaconAccountRiskEvaluateRequest defines the request schema for <c>/v1/beacon/account_risk/risk/evaluate</c></para>
/// </summary>
public partial class BeaconAccountRiskEvaluateRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/beacon/account_risk/v1/evaluate</c> results to a subset of the accounts on the linked Item.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.BeaconAccountRiskEvaluateRequestOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple evaluations and/or multiple linked accounts. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>Unique identifier of what you are looking to evaluate (account add, information change, etc.) to allow us to tie the activity to the decisions and possible fraud outcome sent via our feedback endpoints. You can use your internal request ID or similar.</para>
	/// </summary>
	[JsonPropertyName("client_evaluation_id")]
	public string? ClientEvaluationId { get; set; } = default!;

	/// <summary>
	/// <para>Description of the reason you want to evaluate risk.</para>
	/// </summary>
	[JsonPropertyName("evaluation_reason")]
	public Entity.BeaconAccountRiskEvaluateEvaluationReason? EvaluationReason { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user's device. These fields are optional, but strongly recommended to increase the accuracy of results when using Signal Transaction Scores. When using a Balance-only Ruleset, these fields are ignored if the Signal Addendum has been signed; if it has not been signed, using these fields will result in an error.</para>
	/// </summary>
	[JsonPropertyName("device")]
	public Entity.SignalEvaluateDevice? Device { get; set; } = default!;

	/// <summary>
	/// <para>The time the event for evaluation has occurred. Populate this field for backfilling data. If you don’t populate this field, we’ll use the timestamp at the time of receipt. Use ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ).</para>
	/// </summary>
	[JsonPropertyName("evaluate_time")]
	public DateOnly? EvaluateTime { get; set; } = default!;

}
