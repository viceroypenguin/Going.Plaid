namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/identity/get</c> endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses. Only name data is guaranteed to be returned; other fields will be empty arrays if not provided by the institution.</para>
	/// <para>Note: This request may take some time to complete if identity was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#identityget" /></remarks>
	public Task<Identity.IdentityGetResponse> IdentityGetAsync(Identity.IdentityGetRequest request) =>
		PostAsync("/identity/get", request)
			.ParseResponseAsync<Identity.IdentityGetResponse>();
}