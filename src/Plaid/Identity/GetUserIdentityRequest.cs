namespace Acklann.Plaid.Identity
{
    /// <summary>
    /// Represents a request for plaid's '/identity/get' endpoint. The Identity endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
    /// </summary>
    /// <remarks>Note: This request may take some time to complete if identity was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.</remarks>
    /// <seealso cref="Acklann.Plaid.RequestBase" />
    public class GetUserIdentityRequest : RequestBase { }
}