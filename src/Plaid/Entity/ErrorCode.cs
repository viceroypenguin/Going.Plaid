using System.Runtime.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// The particular error code.
	/// </summary>
	public enum ErrorCode
	{
		#region ITEM_ERROR codes
		/// <summary>
		/// The financial institution indicated that the credentials provided were invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#invalid_credentials"/></remarks>
		[EnumMember(Value = "INVALID_CREDENTIALS")]
		InvalidCredentials,

		/// <summary>
		/// The institution indicated that the provided reponse for the selected device and OTP code was invalid.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#invalid_mfa-otp-device--code"/></remarks>
		[EnumMember(Value = "INVALID_MFA")]
		InvalidMfa,

		/// <summary>
		/// The financial institution indicated that the user's password or MFA information has changed. They will need to reauthenticate via Link's update mode.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#item_login_required"/></remarks>
		[EnumMember(Value = "ITEM_LOGIN_REQUIRED")]
		ItemLoginRequired,

		/// <summary>
		/// The user did not provide sufficient authorization in order to link their account via an OAuth login flow.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#insufficient_credentials-or-oauth-user-declined"/></remarks>
		[EnumMember(Value = "INSUFFICIENT_CREDENTIALS")]
		InsufficientCredentials,

		/// <summary>
		/// The financial institution indicated that the user's account is locked. The user will need to work with the institution directly to unlock their account.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#item_locked"/></remarks>
		[EnumMember(Value = "ITEM_LOCKED")]
		ItemLocked,

		/// <summary>
		/// The user must log in directly to the financial institution and take some action before Plaid can access their accounts.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#user_setup_required"/></remarks>
		[EnumMember(Value = "USER_SETUP_REQUIRED")]
		UserSetupRequired,

		/// <summary>
		/// Returned when the user requires a form of MFA that Plaid does not support for a given financial institution.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#mfa_not_supported"/></remarks>
		[EnumMember(Value = "MFA_NOT_SUPPORTED")]
		MfaNotSupported,

		/// <summary>
		/// Returned when the method used to send MFA credentials was deemed invalid by the insitution.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#invalid_send_method"/></remarks>
		[EnumMember(Value = "INVALID_SEND_METHOD")]
		InvalidSendMethod,

		/// <summary>
		/// Returned when there are no open accounts associated with the Item.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#no_accounts"/></remarks>
		[EnumMember(Value = "NO_ACCOUNTS")]
		NoAccounts,

		/// <summary>
		/// Plaid is unable to support this user's accounts due to restrictions in place at the financial institution.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#item_not_supported"/></remarks>
		[EnumMember(Value = "ITEM_NOT_SUPPORTED")]
		ItemNotSupported,

		/// <summary>
		/// The username entered during update mode did not match the original username.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#invalid_updated_username"/></remarks>
		[EnumMember(Value = "INVALID_UPDATED_USERNAME")]
		InvalidUpdatedUsername,

		/// <summary>
		/// The Link flow in update mode was completed for an Item that is already in a good state. No further action is required.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#item_no_error-or-item-no-error"/></remarks>
		[EnumMember(Value = "ITEM_NO_ERROR")]
		ItemNoError,

		/// <summary>
		/// Returned from <see cref="PlaidClient.FetchAccountInfoAsync(Auth.GetAccountInfoRequest)"/> 
		/// when there are no valid checking or savings account(s) for which account and routing numbers 
		/// could be retrieved.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#no_auth_accounts-or-no-depository-accounts"/></remarks>
		[EnumMember(Value = "NO_AUTH_ACCOUNTS")]
		NoAuthAccounts,

		/// <summary>
		/// Returned from <see cref="PlaidClient.FetchInvestmentHoldingsAsync(Investments.GetInvestmentHoldingsRequest)"/>, 
		/// <see cref="PlaidClient.FetchInvestmentTransactionsAsync(Investments.GetInvestmentTransactionsRequest)"/>, 
		/// or Link initialized with the Investments product, when there are no valid investment account(s) for which 
		/// holdings or transactions could be retrieved.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#no_investment_accounts"/></remarks>
		[EnumMember(Value = "NO_INVESTMENT_ACCOUNTS")]
		NoInvestmentAccounts,


		/// <summary>
		/// Returned from <see cref="PlaidClient.FetchInvestmentHoldingsAsync(Investments.GetInvestmentHoldingsRequest)"/> or
		/// <see cref="PlaidClient.FetchInvestmentTransactionsAsync(Investments.GetInvestmentTransactionsRequest)"/>, 
		/// when there are no valid investment account(s) for which holdings or transactions could be retrieved.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#no_investment_auth_accounts"/></remarks>
		[EnumMember(Value = "NO_INVESTMENT_AUTH_ACCOUNTS")]
		NoInvestmentAuthAccounts,

		/// <summary>
		/// Returned when a data request has been made for an Item for a product that it does not support. 
		/// Use the <see cref="PlaidClient.FetchItemAsync(Management.GetItemRequest)"/> API call to find 
		/// out which products an Item supports.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#products_not_supported"/></remarks>
		[EnumMember(Value = "PRODUCTS_NOT_SUPPORTED")]
		ProductsNotSupported,

		/// <summary>
		/// The Item you requested cannot be found. This Item does not exist, has been previously removed via 
		/// <see cref="PlaidClient.DeleteItemAsync(Management.DeleteItemRequest)"/>, 
		/// or has had access removed by the user
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#item_not_found"/></remarks>
		[EnumMember(Value = "ITEM_NOT_FOUND")]
		ItemNotFound,

		/// <summary>
		/// Returned when a data request has been made for a product that is not yet ready.
		/// </summary>
		/// <remarks><see href="https://plaid.com/docs-beta/errors/item/#product_not_ready"/></remarks>
		[EnumMember(Value = "PRODUCT_NOT_READY")]
		ProductNotReady,
		#endregion
	}
}
