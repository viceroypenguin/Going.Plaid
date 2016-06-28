using System;

namespace Gigobyte.Plaid.Exceptions
{
    /// <summary>
    /// Represents an error that occurred while make a plaid API request.
    /// </summary>
    /// <seealso cref="System.Exception"/>
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
        /// <param name="message">The message.</param>
        /// <param name="errorCode">The error code.</param>
        public PlaidException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets the response code.
        /// </summary>
        /// <value>The response code.</value>
        public ResponseCode ResponseCode
        {
            get { return ErrorCode.ConvertToResponseCode(); }
        }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        /// <value>The error code.</value>
        public int ErrorCode { get; internal set; }
    }
}