namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/institutions/search</c> results.</para>
/// </summary>
public class InstitutionsSearchRequestOptions
{
	/// <summary>
	/// <para>Limit results to institutions with or without OAuth login flows. This is primarily relevant to institutions with European country codes</para>
	/// </summary>
	[JsonPropertyName("oauth")]
	public bool Oauth { get; set; } = default!;

	/// <summary>
	/// <para>When true, return the institution's homepage URL, logo and primary brand color.</para>
	/// </summary>
	[JsonPropertyName("include_optional_metadata")]
	public bool IncludeOptionalMetadata { get; set; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.</para>
	/// </summary>
	[JsonPropertyName("include_payment_initiation_metadata")]
	public bool IncludePaymentInitiationMetadata { get; set; } = default!;

	/// <summary>
	/// <para>Additional options that will be used to filter institutions by various Payment Initiation configurations.</para>
	/// </summary>
	[JsonPropertyName("payment_initiation")]
	public Entity.InstitutionsSearchPaymentInitiationOptions? PaymentInitiation { get; set; } = default!;
}