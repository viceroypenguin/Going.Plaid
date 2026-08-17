namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaIssuesV1ListRequest defines the request schema for <c>/beta/issues/v1/list</c>.</para>
/// </summary>
public partial class BetaIssuesV1ListRequest : RequestBase
{
	/// <summary>
	/// <para>The identifier of the institution whose issues should be returned.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; set; } = default!;

}
