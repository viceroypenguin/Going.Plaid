namespace Going.Plaid.Identity;

/// <summary>
/// <para>IdentityDocumentsUploadsGetRequest defines the request schema for <c>/identity/documents/uploads/get</c></para>
/// </summary>
public partial class IdentityDocumentsUploadsGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/identity/documents/uploads/get</c> results.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.IdentityDocumentsUploadsGetRequestOptions? Options { get; set; } = default!;

}
