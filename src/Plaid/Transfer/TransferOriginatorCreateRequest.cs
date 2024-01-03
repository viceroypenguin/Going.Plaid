namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/originator/create</c></para>
/// </summary>
public partial class TransferOriginatorCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The company name of the end customer being created. This will be displayed in public-facing surfaces, e.g. Plaid Dashboard.</para>
	/// </summary>
	[JsonPropertyName("company_name")]
	public string CompanyName { get; set; } = default!;

}
