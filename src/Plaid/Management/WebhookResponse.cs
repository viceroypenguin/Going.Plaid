using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a response from plaid's webhook.
    /// </summary>
    public class WebhookResponse
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("webhook_type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        [JsonProperty("webhook_code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entity.Item"/> identifier.
        /// </summary>
        /// <value>The item identifier.</value>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the new transactions.
        /// </summary>
        /// <value>The new transactions.</value>
        [JsonProperty("new_transactions")]
        public int NewTransactions { get; set; }

        /// <summary>
        /// Gets or sets the removed transactions.
        /// </summary>
        /// <value>The removed transactions.</value>
        [JsonProperty("removed_transactions")]
        public string[] RemovedTransactions { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>The error.</value>
        [JsonProperty("error")]
        public ErrorDetails Error { get; set; }

        /// <summary>
        /// Gets or sets the new webhook.
        /// </summary>
        /// <value>The new webhook.</value>
        [JsonProperty("new_webhook")]
        public string NewWebhook { get; set; }

        /// <summary>
        /// Represents an error.
        /// </summary>
        public struct ErrorDetails
        {
            /// <summary>
            /// Gets or sets the type of the error.
            /// </summary>
            /// <value>The type of the error.</value>
            [JsonProperty("error_type")]
            public string ErrorType { get; set; }

            /// <summary>
            /// Gets or sets the error code.
            /// </summary>
            /// <value>The error code.</value>
            [JsonProperty("error_code")]
            public string ErrorCode { get; set; }

            /// <summary>
            /// Gets or sets the display message.
            /// </summary>
            /// <value>The display message.</value>
            [JsonProperty("display_message")]
            public string DisplayMessage { get; set; }

            /// <summary>
            /// Gets or sets the http status code.
            /// </summary>
            /// <value>The status.</value>
            [JsonProperty("status")]
            public int Status { get; set; }
        }
    }
}