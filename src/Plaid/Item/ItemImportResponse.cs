namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemImportResponse defines the response schema for <c>/item/import</c></para>
/// </summary>
public record ItemImportResponse : ResponseBase
{
	/// <summary>
	/// <para>The access token associated with the Item data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("access_token")]
	public string AccessToken { get; init; } = default!;

}
