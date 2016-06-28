namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents an abstract plaid API response message.
    /// </summary>
    public abstract class PlaidResponseBase
    {
        /// <summary>
        /// Gets or sets the HTTP status code.
        /// </summary>
        /// <value>The HTTP status code.</value>
        public System.Net.HttpStatusCode StatusCode { get; set; }
    }
}