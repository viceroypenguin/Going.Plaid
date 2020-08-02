namespace Going.Plaid.Category
{
	/// <summary>
	/// Represents a request for plaid's '<c>/categories/get</c>' endpoint. Send a request to the '<c>/categories/get</c>' endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.
	/// </summary>
	public class GetCategoriesRequest : RequestBase
	{
		/// <inheritdoc/>
		public override void SetCredentials(string? secret, string? clientId, string? accessToken)
		{
			Secret = null;
			ClientId = null;
			AccessToken = null;
		}
	}
}
