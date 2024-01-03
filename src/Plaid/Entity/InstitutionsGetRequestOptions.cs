namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/institutions/get</c> results.</para>
/// </summary>
public class InstitutionsGetRequestOptions
{
	/// <summary>
	/// <para>Filter the Institutions based on which products they support.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products>? Products { get; set; } = default!;

	/// <summary>
	/// <para>Specify an array of routing numbers to filter institutions. The response will only return institutions that match all of the routing numbers in the array. Routing number records used for this matching are not comprehensive; failure to match a given routing number to an institution does not mean that the institution is unsupported by Plaid.</para>
	/// </summary>
	[JsonPropertyName("routing_numbers")]
	public IReadOnlyList<string>? RoutingNumbers { get; set; } = default!;

	/// <summary>
	/// <para>Limit results to institutions with or without OAuth login flows. Note that institutions will have <c>oauth</c> set to <c>true</c> if some Items associated with that institution are required to use OAuth flows; institutions in a state of migration to OAuth will have the <c>oauth</c> attribute set to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("oauth")]
	public bool? Oauth { get; set; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, return the institution's homepage URL, logo and primary brand color.</para>
	/// <para>Note that Plaid does not own any of the logos shared by the API, and that by accessing or using these logos, you agree that you are doing so at your own risk and will, if necessary, obtain all required permissions from the appropriate rights holders and adhere to any applicable usage guidelines. Plaid disclaims all express or implied warranties with respect to the logos.</para>
	/// </summary>
	[JsonPropertyName("include_optional_metadata")]
	public bool? IncludeOptionalMetadata { get; set; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, returns metadata related to the Auth product indicating which auth methods are supported.</para>
	/// </summary>
	[JsonPropertyName("include_auth_metadata")]
	public bool? IncludeAuthMetadata { get; set; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.</para>
	/// </summary>
	[JsonPropertyName("include_payment_initiation_metadata")]
	public bool? IncludePaymentInitiationMetadata { get; set; } = default!;

}
