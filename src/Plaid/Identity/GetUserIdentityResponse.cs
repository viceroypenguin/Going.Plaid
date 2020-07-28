namespace Going.Plaid.Identity
{
	/// <summary>
	/// Represents a response from plaid's '<c>/identity/get</c>' endpoint. The Identity endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
	/// </summary>
	/// <remarks>Note: This request may take some time to complete if identity was not specified as an initial product when creating the <see cref="Entity.Item" />. This is because Plaid must communicate directly with the institution to retrieve the data.</remarks>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class GetUserIdentityResponse : ResponseBase
	{
		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		public Entity.Item Item { get; set; } = null!;

		/// <summary>
		/// The accounts attached to the <see cref="Item"/>
		/// </summary>
		public Entity.Account[] Accounts { get; set; } = null!;
	}
}
