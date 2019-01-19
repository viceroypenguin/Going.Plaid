using Newtonsoft.Json;
using System;

namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Represents a banking transaction.
    /// </summary>
    /// <remarks>
    /// Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
    /// </remarks>
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique id of the transaction.
        /// </summary>
        /// <value>The transaction identifier.</value>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the id of the account in which this transaction occurred.
        /// </summary>
        /// <value>The account identifier.</value>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the hierarchical array of the categories to which this transaction.
        /// </summary>
        /// <value>The categories.</value>
        [JsonProperty("category")]
        public string[] Categories { get; set; }

        /// <summary>
        /// Gets or sets the id of the category to which this transaction belongs. See https://plaid.com/docs/api/#categories.
        /// </summary>
        /// <value>The category identifier.</value>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the type of the transaction.
        /// </summary>
        /// <value>The type of the transaction.</value>
        [JsonProperty("transaction_type")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or sets the settled dollar value. Positive values when money moves out of the account; negative values when money moves in. For example, purchases are positive; credit card payments, direct deposits, refunds are negative.
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty("amount")]
        public float Amount { get; set; }

        /// <summary>
        /// The ISO currency code of the transaction, either USD or CAD. Always null if unofficial_currency_code is non-null.
        /// </summary>
        /// <value>The ISO currency code.</value>
        [JsonProperty("iso_currency_code")]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// The unofficial currency code associated with the transaction. Always null if iso_currency_code is non-null.
        /// </summary>
        /// <value>The unofficial currency code.</value>
        [JsonProperty("unofficial_currency_code")]
        public string UnofficialCurrencyCode { get; set; }

        /// <summary>
        /// Gets the currency code from either IsoCurrencyCode or UnofficialCurrencyCode. If non-null, IsoCurrencyCode is returned, else if non-null, UnofficialCurrencyCode, else null is returned.
        /// </summary>
        /// <value>Either available currency code.</value>
        public string CurrencyCode => IsoCurrencyCode ?? UnofficialCurrencyCode ?? null;

        /// <summary>
        /// Gets or sets the date of the transaction.
        /// </summary>
        /// <value>The date.</value>
        /// <remarks>For pending transactions, Plaid returns the date the transaction occurred; for posted transactions, Plaid returns the date the transaction posts.</remarks>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the information of the merchant's location. Typically <c>null</c>.
        /// </summary>
        /// <value>The location details.</value>
        [JsonProperty("location")]
        public LocationInfo Location { get; set; }

        /// <summary>
        /// Gets or sets the information of the payment and payment processor. Typically <c>null</c>.
        /// </summary>
        /// <value>The payment details.</value>
        [JsonProperty("payment_meta")]
        public PaymentInfo Payment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Transaction"/> is pending or unsettled. Pending transaction details (name, <see cref="TransactionType"/>, <see cref="Amount"/>) may change before they are settled.
        /// </summary>
        /// <value><c>true</c> if pending; otherwise, <c>false</c>.</value>
        [JsonProperty("pending")]
        public bool Pending { get; set; }

        /// <summary>
        /// Gets or sets the id of a posted transaction's associated pending transaction.
        /// </summary>
        /// <value>The pending transaction identifier.</value>
        [JsonProperty("pending_transaction_id")]
        public string PendingTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the name of the account owner. This property is not typically populated and only relevant when dealing with sub-accounts.
        /// </summary>
        /// <value>The account owner.</value>
        [JsonProperty("account_owner")]
        public string AccountOwner { get; set; }

        /// <summary>
        /// Gets the transaction type.
        /// </summary>
        /// <value>The transaction type.</value>
        public TransactionType Type
        {
            get
            {
                bool valid = Enum.TryParse(TransactionType, out TransactionType type);
                return valid ? type : Entity.TransactionType.Unresolved;
            }
        }

        /// <summary>
        /// Represents a geographical location.
        /// </summary>
        public struct LocationInfo
        {
            /// <summary>
            /// Gets or sets the address.
            /// </summary>
            /// <value>The address.</value>
            [JsonProperty("address")]
            public string Address { get; set; }

            /// <summary>
            /// Gets or sets the city.
            /// </summary>
            /// <value>The city.</value>
            [JsonProperty("city")]
            public string City { get; set; }

            /// <summary>
            /// Gets or sets the state.
            /// </summary>
            /// <value>The state.</value>
            [JsonProperty("state")]
            public string State { get; set; }

            /// <summary>
            /// Gets or sets the zip.
            /// </summary>
            /// <value>The zip.</value>
            [JsonProperty("zip")]
            public string Zip { get; set; }

            /// <summary>
            /// Gets or sets the latitude (x-coordinate).
            /// </summary>
            /// <value>The latitude.</value>
            [JsonProperty("lat")]
            public double? Latitude { get; set; }

            /// <summary>
            /// Gets or sets the longitude (y-coordinate).
            /// </summary>
            /// <value>The longitude.</value>
            [JsonProperty("lon")]
            public double? Longitude { get; set; }

            /// <summary>
            /// Gets or sets the store number.
            /// </summary>
            /// <value>The store number.</value>
            [JsonProperty("store_number")]
            public string StoreNumber { get; set; }
        }

        /// <summary>
        /// Metadata about the customer and merchant.
        /// </summary>
        public struct PaymentInfo
        {
            /// <summary>
            /// Gets or sets the reference number.
            /// </summary>
            /// <value>The reference number.</value>
            [JsonProperty("reference_number")]
            public string ReferenceNumber { get; set; }

            /// <summary>
            /// Gets or sets the PPD identifier.
            /// </summary>
            /// <value>The PPD identifier.</value>
            [JsonProperty("ppd_id")]
            public string PPDId { get; set; }

            /// <summary>
            /// Gets or sets the name of the payee.
            /// </summary>
            /// <value>The name of the payee.</value>
            [JsonProperty("payee")]
            public string PayeeName { get; set; }

            /// <summary>
            /// Gets or sets the name of the payer.
            /// </summary>
            /// <value>The name of the payer.</value>
            [JsonProperty("payer")]
            public string Payer { get; set; }

            /// <summary>
            /// Gets or sets the payment processor.
            /// </summary>
            /// <value>The payment processor.</value>
            [JsonProperty("payment_processor")]
            public string PaymentProcessor { get; set; }

            /// <summary>
            /// Gets or sets the reason.
            /// </summary>
            /// <value>The reason.</value>
            [JsonProperty("reason")]
            public string Reason { get; set; }

            /// <summary>
            /// Gets or sets the by order of.
            /// </summary>
            /// <value>The by order of.</value>
            [JsonProperty("by_order_of")]
            public string ByOrderOf { get; set; }
        }
    }
}