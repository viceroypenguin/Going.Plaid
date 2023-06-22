namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/institutions/search</c> results.</para>
/// </summary>
public class InstitutionsSearchRequestOptions
{
	/// <summary>
	/// <para>Limit results to institutions with or without OAuth login flows. Note that institutions will have <c>oauth</c> set to <c>true</c> if some Items associated with that institution are required to use OAuth flows; institutions in a state of migration to OAuth will have the <c>oauth</c> attribute set to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("oauth")]
	public bool? Oauth { get; set; } = default!;

	/// <summary>
	/// <para>When true, return the institution's homepage URL, logo and primary brand color.</para>
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

	/// <summary>
	/// <para>Additional options that will be used to filter institutions by various Payment Initiation configurations.</para>
	/// </summary>
	[JsonPropertyName("payment_initiation")]
	public Entity.InstitutionsSearchPaymentInitiationOptions? PaymentInitiation { get; set; } = default!;
}