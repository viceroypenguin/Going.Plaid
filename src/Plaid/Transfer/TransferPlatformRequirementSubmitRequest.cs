namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/platform/requirement/submit</c></para>
/// </summary>
public partial class TransferPlatformRequirementSubmitRequest : RequestBase
{
	/// <summary>
	/// <para>The client ID of the originator</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>Use the <c>/transfer/platform/requirement/submit</c> endpoint to submit a list of requirement submissions that all relate to the originator. Must contain between 1 and 50 requirement submissions. See <a href="https://docs.google.com/document/d/1NEQkTD0sVK50iAQi6xHigrexDUxZ4QxXqSEfV_FFTiU/">Requirement type schema documentation</a> for a list of requirements and possible values.</para>
	/// </summary>
	[JsonPropertyName("requirement_submissions")]
	public IReadOnlyList<Entity.RequirementSubmission> RequirementSubmissions { get; set; } = default!;

}
