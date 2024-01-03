namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies optional parameters for <c>/institutions/get_by_id</c>. If provided, must not be <c>null</c>.</para>
/// </summary>
public class InstitutionsGetByIdRequestOptions
{
	/// <summary>
	/// <para>When <c>true</c>, return an institution's logo, brand color, and URL. When available, the bank's logo is returned as a base64 encoded 152x152 PNG, the brand color is in hexadecimal format. The default value is <c>false</c>.</para>
	/// <para>Note that Plaid does not own any of the logos shared by the API and that by accessing or using these logos, you agree that you are doing so at your own risk and will, if necessary, obtain all required permissions from the appropriate rights holders and adhere to any applicable usage guidelines. Plaid disclaims all express or implied warranties with respect to the logos.</para>
	/// </summary>
	[JsonPropertyName("include_optional_metadata")]
	public bool? IncludeOptionalMetadata { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, the response will include status information about the institution. Default value is <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("include_status")]
	public bool? IncludeStatus { get; set; } = default!;

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
