using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Represents a bank account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("account_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Item"/> identifier.
        /// </summary>
        /// <value>The item identifier.</value>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the financial <see cref="Institution"/> identifier associated with the account.
        /// </summary>
        /// <value>The institution identifier.</value>
        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the last four digits of the Account's number.
        /// </summary>
        /// <value>The mask.</value>
        [JsonProperty("mask")]
        public string Mask { get; set; }

        /// <summary>
        /// Gets or sets the official name of the account.
        /// </summary>
        /// <value>The official name of the account.</value>
        [JsonProperty("official_name")]
        public string OfficialName { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type of the sub.
        /// </summary>
        /// <value>The type of the sub.</value>
        [JsonProperty("subtype")]
        public string SubType { get; set; }

        /// <summary>
        /// Gets or sets the balance. The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
        /// </summary>
        /// <remarks>Note: Not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of <c>null</c>.</remarks>
        /// <value>The balance.</value>
        [JsonProperty("balances")]
        public Balance Balance { get; set; }
    }
}