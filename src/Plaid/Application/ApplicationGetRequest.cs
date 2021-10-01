namespace Going.Plaid.Application;

/// <summary>
/// <para>ApplicationGetResponse defines the schema for <c>/application/get</c></para>
/// </summary>
public partial class ApplicationGetRequest : RequestBase
{
	/// <summary>
	/// <para>This field will map to the application ID that is returned from /item/applications/list, or provided to the institution in an oauth redirect.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string ApplicationId { get; set; } = default!;
}