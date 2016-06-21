using Newtonsoft.Json;
using System;

namespace Gigobyte.Plaid.Model
{
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the unique id of the transaction.
        /// </summary>
        /// <value>The unique identifier.</value>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the id of the account in which the transaction occured.
        /// </summary>
        /// <value>The unique identifier.</value>
        [JsonProperty("_account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>The category identifier.</value>
        [JsonProperty("category")]
        public string CategoryId { get; set; }

        
        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("meta")]
        public string Meta { get; set; }

        [JsonProperty("pending")]
        public bool Pending { get; set; }

        public string ReferenceNumber { get; set; }

        public string PendingTransaction { get; set; }
    }
}