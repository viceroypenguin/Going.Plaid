namespace Going.Plaid.Entity;

/// <summary>
/// <para>A map containing data used to highlight institutions in Link.</para>
/// </summary>
public class LinkTokenCreateInstitutionData
{
	/// <summary>
	/// <para>The routing number of the bank to highlight.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string? RoutingNumber { get; set; } = default!;
}