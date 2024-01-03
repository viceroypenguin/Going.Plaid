namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/originator/create</c></para>
/// </summary>
public record TransferOriginatorCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Client ID of the originator. This identifier will be used when creating transfers and should be stored associated with end user information.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; init; } = default!;

	/// <summary>
	/// <para>The company name of the end customer.</para>
	/// </summary>
	[JsonPropertyName("company_name")]
	public string CompanyName { get; init; } = default!;

}
