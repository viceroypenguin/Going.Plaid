using System.ComponentModel;

namespace Going.Plaid.Link
{
	///<summary>
	/// The particular error code. Each <see cref="PlaidErrorType"/> has a specific set of error_codes.
	///</summary>
	///<remarks>See: <see href = "https://plaid.com/docs/#errors" /></remarks>
	public enum PlaidErrorCode
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
		// See: https://plaid.com/docs/#invalid-request-errors
		#region ErrorType: INVALID_REQUEST

		[Description(
			"The request was missing one or more required fields. " +
			"The error_message field will list the missing field(s).")]
		MISSING_FIELDS,

		[Description(
			"The request included a field that is not recognized by the endpoint. " +
			"The error_message field will list the extraneous field(s).")]
		UNKNOWN_FIELDS,

		[Description("One or more of the request body fields was improperly formatted or an invalid type.")]
		INVALID_FIELD,

		[Description("The request body was invalid. Only JSON bodies are accepted.")]
		INVALID_BODY,

		[Description("The request was missing a required header, typically the Content-Type header.")]
		INVALID_HEADERS,

		[Description("The endpoint requested does not exist.")]
		NOT_FOUND,

		[Description("The requested endpoint is only available in the Sandbox API environment.")]
		SANDBOX_ONLY,

		#endregion ErrorType: INVALID_REQUEST

		// See: https://plaid.com/docs/#invalid-input-errors
		#region ErrorType: INVALID_INPUT

		[Description(
			"The client ID and secret included in the request body were invalid. " +
			"Find your API keys in the Dashboard.")]
		INVALID_API_KEYS,

		[Description(
			"The link_token used to open Link has expired, has already been used to initialize Link, " +
			"or has been used for too many attempts. Create a new link_token with the /link/token/create request.")]
		INVALID_LINK_TOKEN,

		[Description(
			"Your client ID does not have access to this API environment. " +
			"See which environments you are enabled for from the Dashboard.")]
		UNAUTHORIZED_ENVIRONMENT,

		[Description(
			"Access tokens are in the format: access-<environment>-<identifier> " +
			"This error can happen when the access_token you provided is invalid, " +
			"from a different API environment, or has been removed via a /item/remove request.")]
		INVALID_ACCESS_TOKEN,

		[Description(
			"Public tokens are in the format: public-<environment>-<identifier> " +
			"This error can happen when the public_token you provided is invalid, " +
			"from a different API environment, or expired.")]
		INVALID_PUBLIC_TOKEN,

		[Description("Your client ID does not have access to this product. Contact Plaid to gain access.")]
		INVALID_PRODUCT,

		[Description("One of the account_id (s) specified is invalid or does not exist.")]
		INVALID_ACCOUNT_ID,

		[Description("The institution_id specified is invalid or does not exist.")]
		INVALID_INSTITUTION,

		[Description(
			"The user attempted to verify their Manual Same-Day micro-deposit amounts more than 3 " +
			"times and their Item is now permanently locked. The user must retry submitting their " +
			"account information in Link.")]
		TOO_MANY_VERIFICATION_ATTEMPTS,

		#endregion ErrorType: INVALID_INPUT

		// See: https://plaid.com/docs/#rate-limit-exceeded-errors
		#region ErrorType: RATE_LIMIT_EXCEEDED

		[Description("Too many requests were made to the /accounts/get endpoint.")]
		ACCOUNTS_LIMIT,

		[Description("You have exceeded your addition limit in our Development environment. " +
					"To increase it, or raise it from zero, contact Plaid.")]
		ADDITION_LIMIT,

		[Description("Too many requests were made to the /auth/get endpoint.")]
		AUTH_LIMIT,

		[Description("Too many requests were made to the /identity/get endpoint.")]
		IDENTITY_LIMIT,

		[Description("Too many requests were made to the /income/get endpoint.")]
		INCOME_LIMIT,

		[Description("Too many requests were made to the /item/get endpoint.")]
		ITEM_GET_LIMIT,

		[Description("Too many requests were made.")]
		RATE_LIMIT,

		[Description("Too many requests were made to the /transactions/get endpoint.")]
		TRANSACTIONS_LIMIT,

		#endregion ErrorType: RATE_LIMIT_EXCEEDED

		// See: https://plaid.com/docs/#api-errors
		#region ErrorType: API_ERROR

		[Description(
			"Plaid was unable to process the request, either due to an internal system " +
			"issue or an unsupported response from a financial institution.")]
		INTERNAL_SERVER_ERROR,

		[Description(
			"Plaid's systems are in maintenance mode and API operations are disabled. " +
			"Advanced notice will be provided if a maintenance window is ever planned.")]
		PLANNED_MAINTENANCE,

		#endregion ErrorType: API_ERROR

		// See: https://plaid.com/docs/#item-errors
		#region ErrorType: ITEM_ERROR

		[Description("The user did not provide sufficient authorization in order to link their account via an OAuth login flow.")]
		INSUFFICIENT_CREDENTIALS,

		[Description("The financial institution indicated that the credentials provided were invalid.")]
		INVALID_CREDENTIALS,

		[Description("The financial institution indicated that the MFA response(s) provided were invalid.")]
		INVALID_MFA,

		[Description(
			"Plaid could not match up the MFA OTP send method to one of the ones we " +
			"sent to the user or the institution rejected it as invalid for some reason.")]
		INVALID_SEND_METHOD,

		[Description("The username provided in update mode via Link did not match the original username for the Item.")]
		INVALID_UPDATED_USERNAME,

		[Description(
			"The financial institution indicated that the user's account is locked. " +
			"The user will need to work with the institution directly to unlock their account.")]
		ITEM_LOCKED,

		[Description(
			"The financial institution indicated that the user's password or MFA " +
			"information has changed. They will need to reauthenticate via Link's update mode.")]
		ITEM_LOGIN_REQUIRED,

		[Description(
			"Link was initialized in update mode for an Item that is in a good state. " +
			"No further action is required.")]
		ITEM_NO_ERROR,

		[Description(
			"Plaid is unable to support this user's accounts due to restrictions in " +
			"place at the financial institution.")]
		ITEM_NOT_SUPPORTED,

		[Description(
			"The Item you requested cannot be found. This Item does not exist, has been " +
			"previously removed via /item/remove, or has had access removed by the user.")]
		ITEM_NOT_FOUND,

		[Description(
			"The user submitted incorrect Manual Same-Day micro-deposit amounts during Item " +
			"verification in Link.")]
		INCORRECT_DEPOSIT_AMOUNTS,

		[Description(
			"The user must log in directly to the financial institution and take some action " +
			"(agree to updated terms and conditions, change their password, etc.) before Plaid " +
			"can access their accounts.")]
		USER_SETUP_REQUIRED,

		[Description(
			"Returned when the user requires a form of MFA that Plaid does not support " +
			"for a given financial institution.")]
		MFA_NOT_SUPPORTED,

		[Description("Returned when there are no open accounts associated with the Item.")]
		NO_ACCOUNTS,

		[Description(
			"Returned from POST /auth/get when there are no valid checking or savings account(s) " +
			"for which account and routing numbers could be retrieved.")]
		NO_AUTH_ACCOUNTS,

		[Description(
			"Returned from POST /investments/holdings/get or POST /investments/transactions/get " +
			"when there are no valid investment account(s) for which holdings or transactions could be retrieved.")]
		NO_INVESTMENT_ACCOUNTS,

		[Description(
			"Returned from POST /liabilities/get when there are no valid liability account(s) " +
			"for which liabilities could be retrieved.")]
		NO_LIABILITY_ACCOUNTS,

		[Description(
			"Returned when a data request has been made for a product that is not yet ready. " +
			"This primarily happens when attempting to pull transactions prior to the initial pull.")]
		PRODUCT_NOT_READY,

		[Description(
			"For PlaidErrorType.ITEM_ERROR: Returned when a data request has been made for an " +
			"Item for a product that it does not support. Use the /item/get endpoint to find out which " +
			"products an Item supports. For PlaidErrorType.AUTH_ERROR: Calling /auth/get on an Item " +
			"that has not been verified will return this error. Verify the Item manually, or wait for " +
			"automated verification to succeed. For PlaidErrorType.ASSET_REPORT_ERROR: The Asset Report " +
			"is still being generated. Try retrieving the Report again later.")]
		PRODUCTS_NOT_SUPPORTED,

		[Description(
			"Returned when an account cannot be verified using Instant Match. To resolve, ensure " +
			"you are correctly enabling all Auth features when initializing Link.")]
		INSTANT_MATCH_FAILED,

		#endregion ErrorType: ITEM_ERROR

		// See: https://plaid.com/docs/#auth-errors
		#region ErrorType: AUTH_ERROR

		//PRODUCT_NOT_READY,

		[Description(
			"If an Item cannot be verified after 7 days, an error webhook will " +
			"be sent to the webhook specified in the Link configuration")]
		VERIFICATION_EXPIRED,

		#endregion ErrorType: AUTH_ERROR

		// See: https://plaid.com/docs/#asset-report-errors-and-warnings
		#region ErrorType: ASSET_REPORT_ERROR

		[Description(
			"In your request to the /asset_report/create endpoint, you included the " +
			"access_token of an Item for which the assets product was not enabled. " +
			"To fix this error, create the Item again with assets in the Link product array. ")]
		PRODUCT_NOT_ENABLED,

		[Description(
			"Plaid was not able to pull sufficient data to generate the Asset Report. " +
			"The causes field will contain detailed information about the underlying causes " +
			"(e.g., institution maintenance).")]
		DATA_UNAVAILABLE,

		//PRODUCT_NOT_READY,

		[Description(
			"The Asset Report could not be generated for an unknown reason. " +
			"Try creating the Report again later.")]
		ASSET_REPORT_GENERATION_FAILED,

		[Description(
			"The filtered or refreshed Asset Report could not be created because the parent" +
			" Asset Report is not in a good state (for example, it has been deleted).")]
		INVALID_PARENT,

		[Description(
			"You tried to retrieve an Asset Report with Insights but you do not have access " +
			"to this feature. Contact Plaid for more information.")]
		INSIGHTS_NOT_ENABLED,

		[Description(
			"You tried to retrieve an Asset Report with Insights and you do have access " +
			"to the feature, but you did not have permission to create an Asset Report with Insights " +
			"at the time of Asset Report creation. To retrieve this Asset Report as an Asset Report " +
			"with Insights, you will need to recreate the Asset Report.")]
		INSIGHTS_PREVIOUSLY_NOT_ENABLED,

		#endregion ErrorType: ASSET_REPORT_ERROR

		// See: https://plaid.com/docs/#institution-errors
		#region ErrorType: INSTITUTION_ERROR

		[Description("The financial institution is down, either for maintenance or due to an infrastructure issue with their systems.")]
		INSTITUTION_DOWN,

		[Description("The financial institution is failing to respond to some of our requests. Your user may be successful if they retry another time.")]
		INSTITUTION_NOT_RESPONDING,

		[Description("The financial institution is not available this time.")]
		INSTITUTION_NOT_AVAILABLE,

		[Description("Plaid no longer supports this financial institution.")]
		INSTITUTION_NO_LONGER_SUPPORTED,

		#endregion ErrorType: INSTITUTION_ERROR

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
