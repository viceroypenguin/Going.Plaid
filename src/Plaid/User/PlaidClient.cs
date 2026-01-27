namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/user/transactions/refresh</c> is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for a User using the Transactions bundle.</para>
	/// <para>This bundle refreshes only the Transactions product data.</para>
	/// <para>This endpoint is for clients who use the Transactions Insights bundle and want to proactively update all linked Items under a user.</para>
	/// <para>The refresh may succeed or fail on a per-Item basis. Use the <c>results</c> array in the response to understand the outcome for each Item.</para>
	/// <para>This endpoint is distinct from <c>/transactions/refresh</c>, which triggers a refresh for a single Item. Use <c>/user/transactions/refresh</c> to target all Items for a user instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#usertransactionsrefresh" /></remarks>
	public Task<User.UserTransactionsRefreshResponse> UserTransactionsRefreshAsync(User.UserTransactionsRefreshRequest request) =>
		PostAsync("/user/transactions/refresh", request)
			.ParseResponseAsync<User.UserTransactionsRefreshResponse>();

	/// <summary>
	/// <para><c>/user/financial_data/refresh</c> is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for a User using the Financial Insights bundle.</para>
	/// <para>This bundle refreshes the Transactions, Investments, and Liabilities product data.</para>
	/// <para>This endpoint is for clients who use the Transactions Insights bundle and want to proactively update all linked Items under a user.</para>
	/// <para>The refresh may succeed or fail on a per-Item basis. Use the <c>results</c> array in the response to understand the outcome for each Item.</para>
	/// <para>This endpoint is distinct from <c>/transactions/refresh</c>, which triggers a refresh for a single Item. Use <c>/user/financial_data/refresh</c> to target all Items for a user instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#userfinancialdatarefresh" /></remarks>
	public Task<User.UserFinancialDataRefreshResponse> UserFinancialDataRefreshAsync(User.UserFinancialDataRefreshRequest request) =>
		PostAsync("/user/financial_data/refresh", request)
			.ParseResponseAsync<User.UserFinancialDataRefreshResponse>();

	/// <summary>
	/// <para>For Plaid products and flows that use the user object, <c>/user/create</c> provides you a single token to access all data associated with the user. You must call this endpoint before calling <c>/link/token/create</c> if you are using any of the following: Plaid Check, Income Verification, Multi-Item Link, or Plaid Protect.</para>
	/// <para>For customers who began using this endpoint on or after December 10, 2025, this endpoint takes a <c>client_user_id</c> and an <c>identity</c> object and will return a <c>user_id</c>. For customers who began using it before that date, the endpoint takes a <c>client_user_id</c> and a <c>consumer_report_user_identity</c> object and will return a <c>user_token</c> and <c>user_id</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// <para>In order to create a Plaid Check Consumer Report for a user, the <c>identity</c> (new) or <c>consumer_report_user_identity</c> (legacy) object must be present. If it is not provided during the <c>/user/create</c> call, it can be added later by calling <c>/user/update</c>. </para>
	/// <para>In order to generate a Plaid Check Consumer Report, the following <c>identity</c> fields, at minimum, are required and must be non-empty: <c>name</c>, <c>date_of_birth</c>, <c>emails</c>, <c>phone_numbers</c>, and <c>addresses</c>, (with at least one email, phone number, and address designated as <c>primary</c>). Plaid Check Consumer Reports can only be created for US-based users; the user's address country must be <c>US</c>. If creating a report for sharing with a GSE such as Fannie or Freddie, the user's full SSN must be provided via the <c>id_numbers</c> field. Providing at least a partial SSN is also strongly recommended for all use cases, since it improves the accuracy of matching user records during compliance processes such as file disclosure, dispute, or security freeze requests.</para>
	/// <para>When using Plaid Protect, it is highly recommended that you provide an <c>identity</c> object to better identify and block fraud across your Link sessions. </para>
	/// <para>Plaid will normalize identity fields before storing them and utilize the same identity across different user-based products.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#usercreate" /></remarks>
	public Task<User.UserCreateResponse> UserCreateAsync(User.UserCreateRequest request) =>
		PostAsync("/user/create", request)
			.ParseResponseAsync<User.UserCreateResponse>();

	/// <summary>
	/// <para>Get user details using a <c>user_id</c>. This endpoint only supports users that were created on the new user API flow, without a <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userget" /></remarks>
	public Task<User.UserGetResponse> UserGetAsync(User.UserGetRequest request) =>
		PostAsync("/user/get", request)
			.ParseResponseAsync<User.UserGetResponse>();

	/// <summary>
	/// <para>This endpoint allows customers to explicitly purge identity/PII data provided to Plaid for a given user. This is not exposed to customers by default, as it is meant for special scenarios or requests, but Plaid is obligated to enable customers to delete PII provided to us.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#useridentityremove" /></remarks>
	public Task<User.UserIdentityRemoveResponse> UserIdentityRemoveAsync(User.UserIdentityRemoveRequest request) =>
		PostAsync("/user/identity/remove", request)
			.ParseResponseAsync<User.UserIdentityRemoveResponse>();

	/// <summary>
	/// <para>This endpoint updates user information for an existing <c>user_id</c> or <c>user_token</c>. If an existing <c>user_id</c> or <c>user_token</c> is missing fields required for a given use case (e.g. creating a Consumer Report) use <c>/user/update</c> to add values for those fields. </para>
	/// <para>Identity updates use merge semantics: provided fields overwrite existing ones; omitted fields remain unchanged.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userupdate" /></remarks>
	public Task<User.UserUpdateResponse> UserUpdateAsync(User.UserUpdateRequest request) =>
		PostAsync("/user/update", request)
			.ParseResponseAsync<User.UserUpdateResponse>();

	/// <summary>
	/// <para><c>/user/remove</c> deletes a <c>user_id</c> or <c>user_token</c> and and associated information, including any Items associated with the user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userremove" /></remarks>
	public Task<User.UserRemoveResponse> UserRemoveAsync(User.UserRemoveRequest request) =>
		PostAsync("/user/remove", request)
			.ParseResponseAsync<User.UserRemoveResponse>();

	/// <summary>
	/// <para><c>/user/products/terminate</c> terminates user-based recurring subscriptions for a given client user. This will remove user-based products (Financial Management, Protect, and CRA products) from all items associated with the user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userproductsterminate" /></remarks>
	public Task<User.UserProductsTerminateResponse> UserProductsTerminateAsync(User.UserProductsTerminateRequest request) =>
		PostAsync("/user/products/terminate", request)
			.ParseResponseAsync<User.UserProductsTerminateResponse>();

	/// <summary>
	/// <para>Returns Items associated with a <c>user_id</c>, along with their corresponding statuses. Plaid associates an Item with a User when it has been successfully connected within a Link session initialized with that <c>user_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#useritemsget" /></remarks>
	public Task<User.UserItemsGetResponse> UserItemsGetAsync(User.UserItemsGetRequest request) =>
		PostAsync("/user/items/get", request)
			.ParseResponseAsync<User.UserItemsGetResponse>();

	/// <summary>
	/// <para>Associates Items to the target user. If an Item is already associated to another user, the Item will be disassociated with the existing user and associated to the target user. This operation supports a max of 100 Items.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#useritemsassociate" /></remarks>
	public Task<User.UserItemsAssociateResponse> UserItemsAssociateAsync(User.UserItemsAssociateRequest request) =>
		PostAsync("/user/items/associate", request)
			.ParseResponseAsync<User.UserItemsAssociateResponse>();

	/// <summary>
	/// <para>This endpoint is used to delete Items for a given User. Either a <c>user_id</c> or <c>user_token</c> must be provided. If any of the Items are not associated with the provided User, an error will be returned, and no Items will be deleted.</para>
	/// <para>This is equivalent to calling <c>/item/remove</c> on each Item, but this endpoint supports User-based use cases (CRA) where <c>/item/remove</c> is not supported. To obtain a list of Items associated with a User, call <c>/user/items/get</c>. After an Item is deleted, it will no longer appear in <c>/user/items/get</c>. Item deletion via <c>/user/items/remove</c> will permanently and irreversibly delete the Item; to re-create the Item, send the User back through the Link flow.</para>
	/// <para>This endpoint is not intended to remove all data for a User, as it will only remove items and no other data for the User. In the case of a user deleting their account with your product, call <c>/user/products/terminate</c> to stop billing for unneeded services. For a user initiated data deletion request, see the <a href="https://plaid.com/check/consumer-service-center/">Consumer Service Center</a> to revoke access to data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#useritemsremove" /></remarks>
	public Task<User.UserItemsRemoveResponse> UserItemsRemoveAsync(User.UserItemsRemoveRequest request) =>
		PostAsync("/user/items/remove", request)
			.ParseResponseAsync<User.UserItemsRemoveResponse>();

	/// <summary>
	/// <para>This endpoint is used to create a third-party user token. This token can be shared with and used by a specified third-party client to access data associated with the user through supported endpoints.</para>
	/// <para>Ensure you store the <c>third_party_user_token</c> along with the <c>user_token</c> and <c>third_party_client_id</c>, as it is not possible to retrieve a previously created <c>third_party_user_token</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userthirdpartytokencreate" /></remarks>
	public Task<User.UserThirdPartyTokenCreateResponse> UserThirdPartyTokenCreateAsync(User.UserThirdPartyTokenCreateRequest request) =>
		PostAsync("/user/third_party_token/create", request)
			.ParseResponseAsync<User.UserThirdPartyTokenCreateResponse>();

	/// <summary>
	/// <para>This endpoint is used to delete a third-party user token. Once removed, the token can longer be used to access data associated with the user.</para>
	/// <para>Any subsequent calls to retrieve information using the same third-party user token will result in an error stating the third-party user token does not exist.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userthirdpartytokenremove" /></remarks>
	public Task<User.UserThirdPartyTokenRemoveResponse> UserThirdPartyTokenRemoveAsync(User.UserThirdPartyTokenRemoveRequest request) =>
		PostAsync("/user/third_party_token/remove", request)
			.ParseResponseAsync<User.UserThirdPartyTokenRemoveResponse>();

}
