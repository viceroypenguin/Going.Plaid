namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Cashflow Insights product.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsCashflowInsights
{
	/// <summary>
	/// <para>The version of cashflow attributes. Required if using Cash Flow Insights.</para>
	/// </summary>
	[JsonPropertyName("attributes_version")]
	public Entity.CashflowAttributesVersion? AttributesVersion { get; set; } = default!;

}
