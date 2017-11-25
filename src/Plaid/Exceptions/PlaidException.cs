using Newtonsoft.Json;
using System;

namespace Acklann.Plaid.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a response from the Plaid API contains an error.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class PlaidException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaidException"/> class.
        /// </summary>
        public PlaidException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaidException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public PlaidException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaidException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public PlaidException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaidException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        protected PlaidException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Gets or sets the type of the error. A broad categorization of the error.
        /// </summary>
        /// <value>The type of the error.</value>
        [JsonProperty("error_type")]
        public string ErrorType { get; set; }

        /// <summary>
        /// Gets or sets the error code. The particular error code. Each error_type has a specific set
        /// </summary>
        /// <value>The error code.</value>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the display message. A user-friendly representation of the error code. null if the error is not related to user action. This may change over time and is not safe for programmatic use.
        /// </summary>
        /// <value>The display message.</value>
        [JsonProperty("display_message")]
        public string DisplayMessage { get; set; }
    }
}