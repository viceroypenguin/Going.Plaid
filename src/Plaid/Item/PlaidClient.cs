namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>List a historical log of user consent events</para>
	/// </summary>
	public Task<Item.ItemActivityListResponse> ItemActivityListAsync(Item.ItemActivityListRequest request) =>
		PostAsync("/item/activity/list", request)
			.ParseResponseAsync<Item.ItemActivityListResponse>();

	/// <summary>
	/// <para>List a user’s connected applications</para>
	/// </summary>
	public Task<Item.ItemApplicationListResponse> ItemApplicationListAsync(Item.ItemApplicationListRequest request) =>
		PostAsync("/item/application/list", request)
			.ParseResponseAsync<Item.ItemApplicationListResponse>();

	/// <summary>
	/// <para>Unlink a user’s connected application. On an unlink request, Plaid will immediately revoke the Application’s access to the User’s data.  The User will have to redo the OAuth authentication process in order to restore functionality.</para>
	/// <para>This endpoint only removes ongoing data access permissions, therefore the User will need to reach out to the Application itself in order to disable and delete their account and delete any data that the Application already received (if the Application does not do so by default).</para>
	/// <para>This endpoint should be called in real time as the User is unlinking an Application, and should not be batched in order to ensure that the change is reflected as soon as possible.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docsnone" /></remarks>
	public Task<Item.ItemApplicationUnlinkResponse> ItemApplicationUnlinkAsync(Item.ItemApplicationUnlinkRequest request) =>
		PostAsync("/item/application/unlink", request)
			.ParseResponseAsync<Item.ItemApplicationUnlinkResponse>();

	/// <summary>
	/// <para>Enable consumers to update product access on selected accounts for an application.</para>
	/// </summary>
	public Task<Item.ItemApplicationScopesUpdateResponse> ItemApplicationScopesUpdateAsync(Item.ItemApplicationScopesUpdateRequest request) =>
		PostAsync("/item/application/scopes/update", request)
			.ParseResponseAsync<Item.ItemApplicationScopesUpdateResponse>();

	/// <summary>
	/// <para>Returns information about the status of an Item.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/items/#itemget" /></remarks>
	public Task<Item.ItemGetResponse> ItemGetAsync(Item.ItemGetRequest request) =>
		PostAsync("/item/get", request)
			.ParseResponseAsync<Item.ItemGetResponse>();

	/// <summary>
	/// <para>The <c>/item/remove</c> endpoint allows you to remove an Item. Once removed, the <c>access_token</c>, as well as any processor tokens or bank account tokens associated with the Item, is no longer valid and cannot be used to access any data that was associated with the Item.</para>
	/// <para>Calling <c>/item/remove</c> is a recommended best practice when offboarding users or if a user chooses to disconnect an account linked via Plaid. For subscription products, such as Transactions, Liabilities, and Investments, calling <c>/item/remove</c> is required to end subscription billing for the Item. </para>
	/// <para>In Limited Production, calling <c>/item/remove</c> does not impact the number of remaining Limited Production Items you have available.</para>
	/// <para>Removing an Item does not affect any Asset Reports or Audit Copies you have already created, which will remain accessible until you remove access to them specifically using the <c>/asset_report/remove</c> endpoint.</para>
	/// <para>Also note that for certain OAuth-based institutions, an Item removed via <c>/item/remove</c> may still show as an active connection in the institution's OAuth permission manager.</para>
	/// <para>API versions 2019-05-29 and earlier return a <c>removed</c> boolean as part of the response.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/items/#itemremove" /></remarks>
	public Task<Item.ItemRemoveResponse> ItemRemoveAsync(Item.ItemRemoveRequest request) =>
		PostAsync("/item/remove", request)
			.ParseResponseAsync<Item.ItemRemoveResponse>();

	/// <summary>
	/// <para>The POST <c>/item/webhook/update</c> allows you to update the webhook URL associated with an Item. This request triggers a <a href="https://plaid.com/docs/api/items/#webhook_update_acknowledged"><c>WEBHOOK_UPDATE_ACKNOWLEDGED</c></a> webhook to the newly specified webhook URL.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/items/#itemwebhookupdate" /></remarks>
	public Task<Item.ItemWebhookUpdateResponse> ItemWebhookUpdateAsync(Item.ItemWebhookUpdateRequest request) =>
		PostAsync("/item/webhook/update", request)
			.ParseResponseAsync<Item.ItemWebhookUpdateResponse>();

	/// <summary>
	/// <para>By default, the <c>access_token</c> associated with an Item does not expire and should be stored in a persistent, secure manner.</para>
	/// <para>You can use the <c>/item/access_token/invalidate</c> endpoint to rotate the <c>access_token</c> associated with an Item. The endpoint returns a new <c>access_token</c> and immediately invalidates the previous <c>access_token</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/items/#itemaccess_tokeninvalidate" /></remarks>
	public Task<Item.ItemAccessTokenInvalidateResponse> ItemAccessTokenInvalidateAsync(Item.ItemAccessTokenInvalidateRequest request) =>
		PostAsync("/item/access_token/invalidate", request)
			.ParseResponseAsync<Item.ItemAccessTokenInvalidateResponse>();

	/// <summary>
	/// <para>Exchange a Link <c>public_token</c> for an API <c>access_token</c>. Link hands off the <c>public_token</c> client-side via the <c>onSuccess</c> callback once a user has successfully created an Item. The <c>public_token</c> is ephemeral and expires after 30 minutes. An <c>access_token</c> does not expire, but can be revoked by calling <c>/item/remove</c>.</para>
	/// <para>The response also includes an <c>item_id</c> that should be stored with the <c>access_token</c>. The <c>item_id</c> is used to identify an Item in a webhook. The <c>item_id</c> can also be retrieved by making an <c>/item/get</c> request.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/items/#itempublic_tokenexchange" /></remarks>
	public Task<Item.ItemPublicTokenExchangeResponse> ItemPublicTokenExchangeAsync(Item.ItemPublicTokenExchangeRequest request) =>
		PostAsync("/item/public_token/exchange", request)
			.ParseResponseAsync<Item.ItemPublicTokenExchangeResponse>();

	/// <summary>
	/// <para>Note: As of July 2020, the <c>/item/public_token/create</c> endpoint is deprecated. Instead, use <c>/link/token/create</c> with an <c>access_token</c> to create a Link token for use with <a href="https://plaid.com/docs/link/update-mode">update mode</a>.</para>
	/// <para>If you need your user to take action to restore or resolve an error associated with an Item, generate a public token with the <c>/item/public_token/create</c> endpoint and then initialize Link with that <c>public_token</c>.</para>
	/// <para>A <c>public_token</c> is one-time use and expires after 30 minutes. You use a <c>public_token</c> to initialize Link in <a href="https://plaid.com/docs/link/update-mode">update mode</a> for a particular Item. You can generate a <c>public_token</c> for an Item even if you did not use Link to create the Item originally.</para>
	/// <para>The <c>/item/public_token/create</c> endpoint is **not** used to create your initial <c>public_token</c>. If you have not already received an <c>access_token</c> for a specific Item, use Link to obtain your <c>public_token</c> instead. See the <a href="https://plaid.com/docs/quickstart">Quickstart</a> for more information.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/link/#itempublic_tokencreate" /></remarks>
	public Task<Item.ItemPublicTokenCreateResponse> ItemPublicTokenCreateAsync(Item.ItemPublicTokenCreateRequest request) =>
		PostAsync("/item/public_token/create", request)
			.ParseResponseAsync<Item.ItemPublicTokenCreateResponse>();

	/// <summary>
	/// <para><c>/item/import</c> creates an Item via your Plaid Exchange Integration and returns an <c>access_token</c>. As part of an <c>/item/import</c> request, you will include a User ID (<c>user_auth.user_id</c>) and Authentication Token (<c>user_auth.auth_token</c>) that enable data aggregation through your Plaid Exchange API endpoints. These authentication principals are to be chosen by you.</para>
	/// <para>Upon creating an Item via <c>/item/import</c>, Plaid will automatically begin an extraction of that Item through the Plaid Exchange infrastructure you have already integrated.</para>
	/// </summary>
	public Task<Item.ItemImportResponse> ItemImportAsync(Item.ItemImportRequest request) =>
		PostAsync("/item/import", request)
			.ParseResponseAsync<Item.ItemImportResponse>();

}
