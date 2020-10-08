using System.Runtime.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// The particular error code.
	/// </summary>
	public enum ErrorCode
	{
		#region ITEM_ERROR Codes
		/// <summary>
		/// The financial institution indicated that the credentials provided were invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#invalid_credentials"/></remarks>
		[EnumMember(Value = "INVALID_CREDENTIALS")]
		InvalidCredentials,

		/// <summary>
		/// The institution indicated that the provided reponse for the selected device and OTP code was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#invalid_mfa-otp-device--code"/></remarks>
		[EnumMember(Value = "INVALID_MFA")]
		InvalidMfa,

		/// <summary>
		/// The financial institution indicated that the user's password or MFA information has changed. They will need to reauthenticate via Link's update mode.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#item_login_required"/></remarks>
		[EnumMember(Value = "ITEM_LOGIN_REQUIRED")]
		ItemLoginRequired,

		/// <summary>
		/// The user did not provide sufficient authorization in order to link their account via an OAuth login flow.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#insufficient_credentials-or-oauth-user-declined"/></remarks>
		[EnumMember(Value = "INSUFFICIENT_CREDENTIALS")]
		InsufficientCredentials,

		/// <summary>
		/// The financial institution indicated that the user's account is locked. The user will need to work with the institution directly to unlock their account.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#item_locked"/></remarks>
		[EnumMember(Value = "ITEM_LOCKED")]
		ItemLocked,

		/// <summary>
		/// The user must log in directly to the financial institution and take some action before Plaid can access their accounts.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#user_setup_required"/></remarks>
		[EnumMember(Value = "USER_SETUP_REQUIRED")]
		UserSetupRequired,

		/// <summary>
		/// Returned when the user requires a form of MFA that Plaid does not support for a given financial institution.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#mfa_not_supported"/></remarks>
		[EnumMember(Value = "MFA_NOT_SUPPORTED")]
		MfaNotSupported,

		/// <summary>
		/// Returned when the method used to send MFA credentials was deemed invalid by the insitution.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#invalid_send_method"/></remarks>
		[EnumMember(Value = "INVALID_SEND_METHOD")]
		InvalidSendMethod,

		/// <summary>
		/// Returned when there are no open accounts associated with the Item.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#no_accounts"/></remarks>
		[EnumMember(Value = "NO_ACCOUNTS")]
		NoAccounts,

		/// <summary>
		/// Plaid is unable to support this user's accounts due to restrictions in place at the financial institution.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#item_not_supported"/></remarks>
		[EnumMember(Value = "ITEM_NOT_SUPPORTED")]
		ItemNotSupported,

		/// <summary>
		/// The username entered during update mode did not match the original username.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#invalid_updated_username"/></remarks>
		[EnumMember(Value = "INVALID_UPDATED_USERNAME")]
		InvalidUpdatedUsername,

		/// <summary>
		/// The Link flow in update mode was completed for an Item that is already in a good state. No further action is required.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#item_no_error-or-item-no-error"/></remarks>
		[EnumMember(Value = "ITEM_NO_ERROR")]
		ItemNoError,

		/// <summary>
		/// Returned from <see cref="PlaidClient.FetchAccountInfoAsync(Auth.GetAccountInfoRequest)"/> 
		/// when there are no valid checking or savings account(s) for which account and routing numbers 
		/// could be retrieved.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#no_auth_accounts-or-no-depository-accounts"/></remarks>
		[EnumMember(Value = "NO_AUTH_ACCOUNTS")]
		NoAuthAccounts,

		/// <summary>
		/// Returned from <see cref="PlaidClient.FetchInvestmentHoldingsAsync(Investments.GetInvestmentHoldingsRequest)"/>, 
		/// <see cref="PlaidClient.FetchInvestmentTransactionsAsync(Investments.GetInvestmentTransactionsRequest)"/>, 
		/// or Link initialized with the Investments product, when there are no valid investment account(s) for which 
		/// holdings or transactions could be retrieved.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#no_investment_accounts"/></remarks>
		[EnumMember(Value = "NO_INVESTMENT_ACCOUNTS")]
		NoInvestmentAccounts,


		/// <summary>
		/// Returned from <see cref="PlaidClient.FetchInvestmentHoldingsAsync(Investments.GetInvestmentHoldingsRequest)"/> or
		/// <see cref="PlaidClient.FetchInvestmentTransactionsAsync(Investments.GetInvestmentTransactionsRequest)"/>, 
		/// when there are no valid investment account(s) for which holdings or transactions could be retrieved.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#no_investment_auth_accounts"/></remarks>
		[EnumMember(Value = "NO_INVESTMENT_AUTH_ACCOUNTS")]
		NoInvestmentAuthAccounts,

		/// <summary>
		/// Returned when a data request has been made for an Item for a product that it does not support. 
		/// Use the <see cref="PlaidClient.FetchItemAsync(Management.GetItemRequest)"/> API call to find 
		/// out which products an Item supports.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#products_not_supported"/></remarks>
		[EnumMember(Value = "PRODUCTS_NOT_SUPPORTED")]
		ProductsNotSupported,

		/// <summary>
		/// The Item you requested cannot be found. This Item does not exist, has been previously removed via 
		/// <see cref="PlaidClient.DeleteItemAsync(Management.DeleteItemRequest)"/>, 
		/// or has had access removed by the user
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#item_not_found"/></remarks>
		[EnumMember(Value = "ITEM_NOT_FOUND")]
		ItemNotFound,

		/// <summary>
		/// Returned when a data request has been made for a product that is not yet ready.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/item/#product_not_ready"/></remarks>
		[EnumMember(Value = "PRODUCT_NOT_READY")]
		ProductNotReady,
		#endregion

		#region API_ERROR Codes
		/// <summary>
		/// Plaid was unable to process the request
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/api/#internal_server_error-or-plaid-internal-error"/></remarks>
		[EnumMember(Value = "INTERNAL_SERVER_ERROR")]
		InternalServerError,

		/// <summary>
		/// Plaid's systems are undergoing maintenance and API operations are disabled
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/api/#planned_maintenance"/></remarks>
		[EnumMember(Value = "PLANNED_MAINTENANCE")]
		PlannedMaintenance,
		#endregion

		#region INSTITUTION_ERROR Codes
		/// <summary>
		/// The financial institution is down, either for maintenance or due to an infrastructure issue with their systems.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/institution/#institution_down"/></remarks>
		[EnumMember(Value = "INSTITUTION_DOWN")]
		InstitutionDown,

		/// <summary>
		/// The financial institution is failing to respond to some of our requests. Your user may be successful if they retry another time.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/institution/#institution_not_responding"/></remarks>
		[EnumMember(Value = "INSTITUTION_NOT_RESPONDING")]
		InstitutionNotResponding,

		/// <summary>
		/// The financial institution is not available this time.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/institution/#institution_not_available"/></remarks>
		[EnumMember(Value = "INSTITUTION_NOT_AVAILABLE")]
		InstitutionNotAvailable,

		/// <summary>
		/// Plaid no longer supports this financial institution.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/institution/#institution_no_longer_supported"/></remarks>
		[EnumMember(Value = "INSTITUTION_NO_LONGER_SUPPORTED")]
		InstitutionNoLongerSupported,
		#endregion

		#region INVALID_REQUEST Codes
		/// <summary>
		/// The request was missing one or more required fields.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#missing_fields"/></remarks>
		[EnumMember(Value = "MISSING_FIELDS")]
		MissingFields,

		/// <summary>
		/// The request included a field that is not recognized by the endpoint.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#unknown_fields"/></remarks>
		[EnumMember(Value = "UNKNOWN_FIELDS")]
		UnknownFields,

		/// <summary>
		/// One or more of the request body fields was improperly formatted or an invalid type
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#invalid_field"/></remarks>
		[EnumMember(Value = "INVALID_FIELD")]
		InvalidField,

		/// <summary>
		/// The request uses fields that are not compatible with the API version being used.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#incompatible_api_version"/></remarks>
		[EnumMember(Value = "INCOMPATIBLE_API_VERSION")]
		IncompatibleApiVersion,

		/// <summary>
		/// The request body was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#invalid_body"/></remarks>
		[EnumMember(Value = "INVALID_BODY")]
		InvalidBody,

		/// <summary>
		/// The request was missing a required header.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#invalid_headers"/></remarks>
		[EnumMember(Value = "INVALID_HEADERS")]
		InvalidHeaders,

		/// <summary>
		/// The endpoint requested does not exist.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#not_found"/></remarks>
		[EnumMember(Value = "NOT_FOUND")]
		NotFound,

		/// <summary>
		/// The endpoint requested is not available in the API version being used.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#no_longer_available"/></remarks>
		[EnumMember(Value = "NO_LONGER_AVAILABLE")]
		NoLongerAvailable,

		/// <summary>
		/// The requested endpoint is only available in Sandbox.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#sandbox_only"/></remarks>
		[EnumMember(Value = "SANDBOX_ONLY")]
		SandboxOnly,

		/// <summary>
		/// The provided account number was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-request/#invalid_account_number"/></remarks>
		[EnumMember(Value = "INVALID_ACCOUNT_NUMBER")]
		InvalidAccountNumber,
		#endregion

		#region INVALID_INPUT Codes
		/// <summary>
		/// The user attempted to verify their Manual Same-Day micro-deposit amounts more than 3 times and their Item is now permanently locked. The user must retry submitting their account information in Link.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#too_many_verification_attempts"/></remarks>
		[EnumMember(Value = "TOO_MANY_VERIFICATION_ATTEMPTS")]
		TooManyVerificationAttempts,

		/// <summary>
		/// The user submitted incorrect Manual Same-Day micro-deposit amounts during Item verification in Link.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#incorrect_deposit_amounts"/></remarks>
		[EnumMember(Value = "INCORRECT_DEPOSIT_AMOUNTS")]
		IncorrectDepositAmounts,

		/// <summary>
		/// Your client ID does not have access to this API environment. See which environments you are enabled for from the Dashboard.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#unauthorized_environment"/></remarks>
		[EnumMember(Value = "UNAUTHORIZED_ENVIRONMENT")]
		UnauthorizedEnvironment,

		/// <summary>
		/// Your client ID does not have access to this product.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_product"/></remarks>
		[EnumMember(Value = "INVALID_PRODUCT")]
		InvalidProduct,

		/// <summary>
		/// Your client ID does not have access to this route.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#unauthorized_route_access"/></remarks>
		[EnumMember(Value = "UNAUTHORIZED_ROUTE_ACCESS")]
		UnauthorizedRouteAccess,

		/// <summary>
		/// An attempt was made to create an Item without using Link.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#direct_integration_not_enabled"/></remarks>
		[EnumMember(Value = "DIRECT_INTEGRATION_NOT_ENABLED")]
		DirectIntegrationNotEnabled,

		/// <summary>
		/// The client ID and secret included in the request body were invalid. Find your API keys in the Dashboard.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_api_keys"/></remarks>
		[EnumMember(Value = "INVALID_API_KEYS")]
		InvalidApiKeys,

		/// <summary>
		/// The access_token included in the request was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_access_token"/></remarks>
		[EnumMember(Value = "INVALID_ACCESS_TOKEN")]
		InvalidAccessToken,

		/// <summary>
		/// The public_token included in the request was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_public_token"/></remarks>
		[EnumMember(Value = "INVALID_PUBLIC_TOKEN")]
		InvalidPublicToken,

		/// <summary>
		/// The link_token provided to initialize Link was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_link_token"/></remarks>
		[EnumMember(Value = "INVALID_LINK_TOKEN")]
		InvalidLinkToken,

		/// <summary>
		/// The processor_token provided to initialize Link was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_processor_token"/></remarks>
		[EnumMember(Value = "INVALID_PROCESSOR_TOKEN")]
		InvalidProcessorToken,

		/// <summary>
		/// The audit copy token supplied to the server was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_audit_copy_token"/></remarks>
		[EnumMember(Value = "INVALID_AUDIT_COPY_TOKEN")]
		InvalidAuditCopyToken,

		/// <summary>
		/// The supplied account_id is not valid
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_account_id"/></remarks>
		[EnumMember(Value = "INVALID_ACCOUNT_ID")]
		InvalidAccountId,

		/// <summary>
		/// The institution_id specified is invalid or does not exist.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_institution"/></remarks>
		[EnumMember(Value = "INVALID_INSTITUTION")]
		InvalidInstitution,

		/// <summary>
		/// The credential fields provided do not match the requirements of the institution.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/invalid-input/#invalid_credential_fields"/></remarks>
		[EnumMember(Value = "INVALID_CREDENTIAL_FIELDS")]
		InvalidCredentialFields,
		#endregion

		#region RATE_LIMIT_EXCEEDED Codes
		/// <summary>
		/// Too many requests were made to the /accounts/get endpoint.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/rate-limit-exceeded/#accounts_limit"/></remarks>
		[EnumMember(Value = "ACCOUNTS_LIMIT")]
		AccountsLimit,

		/// <summary>
		/// You have exceeded your addition limit in our Development environment. To increase it, or raise it from zero, contact us.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/rate-limit-exceeded/#addition_limit"/></remarks>
		[EnumMember(Value = "ADDITION_LIMIT")]
		AdditionLimit,

		/// <summary>
		/// Too many requests were made to the /auth/get endpoint.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/rate-limit-exceeded/#auth_limit"/></remarks>
		[EnumMember(Value = "AUTH_LIMIT")]
		AuthLimit,

		/// <summary>
		/// Too many requests were made to the /accounts/balance/get endpoint.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/rate-limit-exceeded/#balance_limit"/></remarks>
		[EnumMember(Value = "BALANCE_LIMIT")]
		BalanceLimit,

		/// <summary>
		/// Too many requests were made to the /identity/get endpoint.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/rate-limit-exceeded/#identity_limit"/></remarks>
		[EnumMember(Value = "IDENTITY_LIMIT")]
		IdentityLimit,

		/// <summary>
		/// Too many requests were made to the /item/get endpoint.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/rate-limit-exceeded/#item_get_limit"/></remarks>
		[EnumMember(Value = "ITEM_GET_LIMIT")]
		ItemGetLimit,

		/// <summary>
		/// Too many requests were made.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/rate-limit-exceeded/#rate_limit"/></remarks>
		[EnumMember(Value = "RATE_LIMIT")]
		RateLimit,

		/// <summary>
		/// Too many requests were made to the /transactions/get endpoint.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/rate-limit-exceeded/#transactions_limit"/></remarks>
		[EnumMember(Value = "TRANSACTIONS_LIMIT")]
		TransactionsLimit,
		#endregion

		#region RECAPTCHA_ERROR Codes
		/// <summary>
		/// The request was flagged by Plaid's fraud system, and requires additional verification to ensure they are not a bot.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/recaptcha/#recaptcha_required"/></remarks>
		[EnumMember(Value = "RECAPTCHA_REQUIRED")]
		RecaptchaRequired,

		/// <summary>
		/// The provided challenge response was denied.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/recaptcha/#recaptcha_bad"/></remarks>
		[EnumMember(Value = "RECAPTCHA_BAD")]
		RecaptchaBad,
		#endregion

		#region LINK_ERROR Codes
		/// <summary>
		/// The user is trying to link to an institution with poor Plaid connectivity health.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/link/#institution-poor-health-error"/></remarks>
		[EnumMember(Value = "institution-poor-health-error")]
		InstitutionPoorHealthError,
		#endregion

		#region OAUTH_ERROR Codes
		/// <summary>
		/// An incorrect OAuth nonce was supplied when re-initializing Link.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/oauth/#incorrect_oauth_nonce"/></remarks>
		[EnumMember(Value = "INCORRECT_OAUTH_NONCE")]
		IncorrectOauthNonce,

		/// <summary>
		/// The OAuth state has already been processed.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/oauth/#oauth_state_id_already_processed"/></remarks>
		[EnumMember(Value = "OAUTH_STATE_ID_ALREADY_PROCESSED")]
		OauthStateIdAlreadyProcessed,
		#endregion

		#region SANDBOX_ERROR Codes
		/// <summary>
		/// The requested product is not enabled for an Item
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/sandbox/#sandbox_product_not_enabled"/></remarks>
		[EnumMember(Value = "SANDBOX_PRODUCT_NOT_ENABLED")]
		SandboxProductNotEnabled,

		/// <summary>
		/// The request to fire a Sandbox webhook failed.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs/errors/sandbox/#sandbox_webhook_invalid"/></remarks>
		[EnumMember(Value = "SANDBOX_WEBHOOK_INVALID")]
		SandboxWebhookInvalid,
		#endregion
	}
}
