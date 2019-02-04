using Newtonsoft.Json;

namespace Acklann.Plaid.Auth
{
    /// <summary>
    /// Represents a request for plaid's '/auth/get' endpoint. The '/auth/get' endpoint allows you to retrieve the bank account and routing numbers associated with an <see cref="Entity.Item"/>’s checking and savings accounts, along with high-level account data and balances.
    /// </summary>
    /// <remarks>
    /// The Auth product performs two crucial functions. It translates bank access credentials (username and password) into an account and routing number. No input of account or routing number is necessary. It also validates the owner of this account number in a NACHA-compliant manner. This eliminates the need for micro-deposits or any other secondary authentication.
    /// </remarks>
    /// <seealso cref="Acklann.Plaid.RequestBase" />
    public class GetAccountInfoRequest : RequestBase
    {
        
        /// <summary>
        /// Gets or sets the options attached to the request
        /// </summary>
        /// <value>The account ids.</value>
        [JsonProperty("options")]
        public GetAccountInfoOptions Options { get; set; }
    }

    /// <summary>
    /// The container object for options associated with a GetAccountInfoRequest.
    /// </summary>
    /// <remarks>
    /// This is outside the GetAccountInfoRequest class because it is required to build the request.
    /// </remarks>
    public struct GetAccountInfoOptions
    {
        /// <summary>
        /// Gets or sets the list of account_ids to retrieve for the Item. Note: An error will be returned if a provided account_id is not associated with the Item.
        /// </summary>
        /// <value>The account ids.</value>
        [JsonProperty("account_ids")]
        public string[] AccountIds { get; set; }
    }
}