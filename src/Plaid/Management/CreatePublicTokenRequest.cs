namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a request for plaid's '<c>/item/public_token/create</c>' endpoint. Create a public_token from an access_token for use with Plaid LInk's update mode.
	/// </summary>
	/// <seealso cref="Going.Plaid.SerializableContent" />
	public class CreatePublicTokenRequest : RequestBase { }
}
