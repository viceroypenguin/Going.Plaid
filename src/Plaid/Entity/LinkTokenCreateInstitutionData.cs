namespace Going.Plaid.Entity;

/// <summary>
/// <para>A map containing data used to highlight institutions in Link.</para>
/// </summary>
public class LinkTokenCreateInstitutionData
{
	/// <summary>
	/// <para>The routing number of the bank to highlight in Link. Note: in rare cases, a single routing number can be associated with multiple institutions, e.g. due to a brokerage using another institution to manage ACH on its sweep accounts. If this happens, the bank will not be highlighted in Link even if the routing number is provided.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string? RoutingNumber { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid institution ID of the institution to highlight in Link, such as <c>ins_56</c>. Takes precedence over <c>routing_number</c>; will fall back to <c>routing_number</c> (if provided) if the institution ID is unknown or unavailable for this Link session. This feature is in closed beta, please contact your account manager for more info.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; set; } = default!;

}
