namespace Acklann.Plaid.Identity
{
    /// <summary>
    /// Represents a response from plaid's '/identity/get' endpoint. The Identity endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
    /// </summary>
    /// <remarks>Note: This request may take some time to complete if identity was not specified as an initial product when creating the <see cref="Entity.Item" />. This is because Plaid must communicate directly with the institution to retrieve the data.</remarks>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class GetUserIdentityResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        public Entity.Item Item { get; set; }

        /// <summary>
        /// Gets or sets the accounts.
        /// </summary>
        /// <value>The accounts.</value>
        public Entity.Account[] Accounts { get; set; }

        /// <summary>
        /// Gets or sets the user information.
        /// </summary>
        /// <value>The identity.</value>
        public Entity.Identity Identity { get; set; }
    }
}