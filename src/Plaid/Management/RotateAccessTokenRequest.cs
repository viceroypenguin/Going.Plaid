namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a request for plaid's '<c>/item/access_token/invalidate</c>'. You can use the '<c>/item/access_token/invalidate</c>' endpoint to rotate the access_token associated with an Item. The endpoint returns a new access_token and immediately invalidates the previous access_token.
	/// </summary>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class RotateAccessTokenRequest : RequestBase
	{
	}
}
