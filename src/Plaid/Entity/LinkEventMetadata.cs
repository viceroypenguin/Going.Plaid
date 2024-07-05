namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata about an event that occurred while the user was going through Link</para>
/// </summary>
public record LinkEventMetadata
{
	/// <summary>
	/// <para>The error code that the user encountered. Emitted by <c>ERROR</c>, <c>EXIT</c>.</para>
	/// </summary>
	[JsonPropertyName("error_code")]
	public string? ErrorCode { get; init; } = default!;

	/// <summary>
	/// <para>The error message that the user encountered. Emitted by: <c>ERROR</c>, <c>EXIT</c>.</para>
	/// </summary>
	[JsonPropertyName("error_message")]
	public string? ErrorMessage { get; init; } = default!;

	/// <summary>
	/// <para>The error type that the user encountered. Emitted by: <c>ERROR</c>, <c>EXIT</c>.</para>
	/// </summary>
	[JsonPropertyName("error_type")]
	public string? ErrorType { get; init; } = default!;

	/// <summary>
	/// <para>The status key indicates the point at which the user exited the Link flow. Emitted by: <c>EXIT</c>.</para>
	/// </summary>
	[JsonPropertyName("exit_status")]
	public string? ExitStatus { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the selected institution. Emitted by: all events.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the selected institution. Emitted by: all events.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string? InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The query used to search for institutions. Emitted by: <c>SEARCH_INSTITUTION</c>.</para>
	/// </summary>
	[JsonPropertyName("institution_search_query")]
	public string? InstitutionSearchQuery { get; init; } = default!;

	/// <summary>
	/// <para>The request ID for the last request made by Link. This can be shared with Plaid Support to expedite investigation. Emitted by: all events.</para>
	/// </summary>
	[JsonPropertyName("request_id")]
	public string RequestId { get; init; } = default!;

	/// <summary>
	/// <para>If set, the user has encountered one of the following MFA types: code, device, questions, selections. Emitted by: <c>SUBMIT_MFA</c> and <c>TRANSITION_VIEW</c> when view_name is <c>MFA</c>.</para>
	/// </summary>
	[JsonPropertyName("mfa_type")]
	public string? MfaType { get; init; } = default!;

	/// <summary>
	/// <para>The name of the view that is being transitioned to. Emitted by: <c>TRANSITION_VIEW</c>.</para>
	/// </summary>
	[JsonPropertyName("view_name")]
	public string? ViewName { get; init; } = default!;

	/// <summary>
	/// <para>Either the verification method for a matched institution selected by the user or the Auth Type Select flow type selected by the user. If selection is used to describe selected verification method, then possible values are <c>phoneotp</c> or <c>password</c>;  if selection is used to describe the selected Auth Type Select flow, then possible values are <c>flow_type_manual</c> or <c>flow_type_instant</c>. Emitted by: <c>MATCHED_SELECT_VERIFY_METHOD</c> and <c>SELECT_AUTH_TYPE</c>.</para>
	/// </summary>
	[JsonPropertyName("selection")]
	public string? Selection { get; init; } = default!;

	/// <summary>
	/// <para>The name of the selected brand.</para>
	/// </summary>
	[JsonPropertyName("brand_name")]
	public string? BrandName { get; init; } = default!;

	/// <summary>
	/// <para>The reason this institution was matched, which will be either <c>returning_user</c> or <c>routing_number</c>. Emitted by: <c>MATCHED_SELECT_INSTITUTION</c>.</para>
	/// </summary>
	[JsonPropertyName("match_reason")]
	public string? MatchReason { get; init; } = default!;

	/// <summary>
	/// <para>The routing number submitted by user at the micro-deposits routing number pane. Emitted by <c>SUBMIT_ROUTING_NUMBER</c>.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string? RoutingNumber { get; init; } = default!;

	/// <summary>
	/// <para>The account number mask extracted from the user-provided account number. If the user-inputted account number is four digits long, <c>account_number_mask</c> is empty. Emitted by <c>SUBMIT_ACCOUNT_NUMBER</c>.</para>
	/// </summary>
	[JsonPropertyName("account_number_mask")]
	public string? AccountNumberMask { get; init; } = default!;

}
