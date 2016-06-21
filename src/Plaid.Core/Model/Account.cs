using Newtonsoft.Json;

namespace Gigobyte.Plaid.Model
{
    /// <summary>
    /// Represents a user bank account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the unique id of the account.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the id unique to the accounts of a particular access token.
        /// </summary>
        /// <value>The unique id.</value>
        [JsonProperty("_item")]
        public string Item { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>The balance.</value>
        [JsonProperty("balance")]
        public Balance Balance { get; set; }

        /// <summary>
        /// Gets or sets the additional information pertaining to the account.
        /// </summary>
        /// <value>The meta.</value>
        [JsonProperty("meta")]
        public AccountMetadata Meta { get; set; }

        /// <summary>
        /// Gets or sets financial institution associated with the account.
        /// </summary>
        /// <value>The type of the institution.</value>
        [JsonProperty("institution_type")]
        public string InstitutionType { get; set; }

        public AccountType Type
        {
            get;
            set;
        }
        
        [JsonProperty("type")]
        public string TypeId { get; set; }

        [JsonProperty("subtype")]
        public string SubtypeId { get; set; }

        

        public string SubType { get; set; }
    }
}