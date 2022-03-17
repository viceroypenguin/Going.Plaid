namespace Going.Plaid.Entity;

/// <summary>
/// <para>A broad categorization of the error. Safe for programmatic use.</para>
/// </summary>
public enum CreditBankIncomeErrorType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INTERNAL_SERVER_ERROR")]
	InternalServerError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INSUFFICIENT_CREDENTIALS")]
	InsufficientCredentials,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_LOCKED")]
	ItemLocked,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_SETUP_REQUIRED")]
	UserSetupRequired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "COUNTRY_NOT_SUPPORTED")]
	CountryNotSupported,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INSTITUTION_DOWN")]
	InstitutionDown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INSTITUTION_NO_LONGER_SUPPORTED")]
	InstitutionNoLongerSupported,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INSTITUTION_NOT_RESPONDING")]
	InstitutionNotResponding,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVALID_CREDENTIALS")]
	InvalidCredentials,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVALID_MFA")]
	InvalidMfa,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVALID_SEND_METHOD")]
	InvalidSendMethod,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_LOGIN_REQUIRED")]
	ItemLoginRequired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MFA_NOT_SUPPORTED")]
	MfaNotSupported,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NO_ACCOUNTS")]
	NoAccounts,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_NOT_SUPPORTED")]
	ItemNotSupported,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACCESS_NOT_GRANTED")]
	AccessNotGranted,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}