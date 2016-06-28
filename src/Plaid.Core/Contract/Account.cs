using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents a bank account.
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
        /// Gets or sets the account balance.
        /// </summary>
        /// <value>The balance.</value>
        /// <remarks>
        /// The Current Balance is the total amount of funds in the account. The Available Balance is
        /// the Current Balance less any outstanding holds or debits that have not yet posted to the
        /// account. Note that not all institutions calculate the Available Balance. In the case that
        /// Available Balance is unavailable from the institution, Plaid will either return an
        /// Available Balance value of null or only return a Current Balance.
        /// </remarks>
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

        /// <summary>
        /// Gets or sets the account type.
        /// </summary>
        /// <value>The account type.</value>
        [JsonProperty("type")]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or sets the account subtype.
        /// </summary>
        /// <remarks>
        /// A more detailed classification of the <see cref="AccountType"/>. When unavailable, this
        /// field will not be returned. See <see cref="AccountSubtype"/> for a list of common subtype values.
        /// </remarks>
        /// <value>The account subtype.</value>
        [JsonProperty("subtype")]
        public string SubtypeId { get; set; }

        /// <summary>
        /// Gets the account type.
        /// </summary>
        /// <value>The type.</value>
        public AccountType Type
        {
            get { return TypeId.ConvertToAccountType(); }
        }

        /// <summary>
        /// Gets the account subtype.
        /// </summary>
        /// <value>The account subtype.</value>
        public AccountSubtype SubType
        {
            get { return SubtypeId.ConvertToAccountSubtype(); }
        }
    }
}