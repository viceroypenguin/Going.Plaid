using Newtonsoft.Json;
using System;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents a bank transaction.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the unique id of the transaction.
        /// </summary>
        /// <value>The unique identifier.</value>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [JsonProperty("name")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the id of the account in which the transaction occurred.
        /// </summary>
        /// <value>The unique identifier.</value>
        [JsonProperty("_account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>The category identifier.</value>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the numeric representation of Plaid's confidence in the meta data they
        /// attached to the transaction.
        /// </summary>
        /// <value>The score.</value>
        //[JsonProperty("score")]
        //public string Score { get; set; }

        

        /// <summary>
        /// Gets or sets the settled dollar value.
        /// </summary>
        /// <value>The amount.</value>
        /// <remarks>
        /// Positive values when money moves out of the account; negative values when money moves in.
        /// For example, purchases are positive; credit card payments, direct deposits, refunds are negative.
        /// </remarks>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the that the transaction took place in ISO 8601 format.
        /// </summary>
        /// <value>The date.</value>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the hierarchical array of the categories to which this transaction belongs.
        /// </summary>
        /// <value>The categories.</value>
        [JsonProperty("category")]
        public string[] Categories { get; set; }

        /// <summary>
        /// Gets or sets the meta data.
        /// </summary>
        /// <value>The meta data.</value>
        [JsonProperty("meta")]
        public TransactionMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Transaction"/> is pending/unsettled.
        /// </summary>
        /// <value><c>true</c> if pending; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// When true, identifies the transaction as pending or unsettled. Pending transaction
        /// details (name, type, amount) may change before they are settled.
        /// </remarks>
        [JsonProperty("pending")]
        public bool Pending { get; set; }

        /// <summary>
        /// Gets or sets the unique attribute that is used by the bank/payment processor to identify
        /// transactions—where applicable.
        /// </summary>
        /// <value>The reference number.</value>
        [JsonProperty("_reference_number")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the id of a posted transaction's associated pending transaction—where applicable.
        /// </summary>
        /// <value>The pending transaction.</value>
        [JsonProperty("_pendingTransaction")]
        public string PendingTransaction { get; set; }
    }
}