namespace Going.Plaid.Entity;

/// <summary>
/// A broad categorization of the error.
/// </summary>
public enum ErrorType
{
	/// <summary>
	/// Occurs when a request is malformed and cannot be processed.
	/// </summary>
	[EnumMember(Value = "INVALID_REQUEST")]
	InvalidRequest,

	/// <summary>
	/// 	Occurs when all fields are provided, but the values provided are incorrect in some way.
	/// </summary>
	[EnumMember(Value = "INVALID_INPUT")]
	InvalidInput,

	/// <summary>
	/// Occurs when there are errors for the requested financial institution.
	/// </summary>
	[EnumMember(Value = "INSTITUTION_ERROR")]
	InstitutionError,

	/// <summary>
	/// Occurs when an excessive number of requests are made in a short period of time.
	/// </summary>
	[EnumMember(Value = "RATE_LIMIT_EXCEEDED_ERROR")]
	RateLimitExceeded,

	/// <summary>
	/// Occurs during planned maintenance and in response to API errors.
	/// </summary>
	[EnumMember(Value = "API_ERROR")]
	ApiError,

	/// <summary>
	/// Occurs when an Item may be invalid or not supported on Plaid's platform.
	/// </summary>
	[EnumMember(Value = "ITEM_ERROR")]
	ItemError,

	/// <summary>
	/// Occurs when there is an error in OAuth authentication, used primarily by European institutions.
	/// </summary>
	[EnumMember(Value = "OAUTH_ERROR")]
	OAuthError,

	/// <summary>
	/// Occurs when a Recaptcha challenge has been presented or failed during the link process.
	/// </summary>
	[EnumMember(Value = "RECAPTCHA_ERROR")]
	RecaptchaError,

	/// <summary>
	/// Occurs when there are errors from Link on the web platform only
	/// </summary>
	[EnumMember(Value = "LINK_ERROR")]
	LinkError,

	/// <summary>
	/// Occurs when there is an error while making a payment.
	/// </summary>
	[EnumMember(Value = "PAYMENT_ERROR")]
	PaymentError,

	/// <summary>
	/// Occurs for errors related to Asset Report endpoints.
	/// </summary>
	[EnumMember(Value = "ASSET_REPORT_ERROR")]
	AssetReportError,

	/// <summary>
	/// Occurs when invalid parameters are supplied in the Sandbox environment.
	/// </summary>
	[EnumMember(Value = "SANDBOX_ERROR")]
	SandboxError,
}
