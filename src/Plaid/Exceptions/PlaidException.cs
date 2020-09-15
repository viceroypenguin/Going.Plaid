using Going.Plaid.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Going.Plaid.Exceptions
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
		/// A broad categorization of the error.
		/// </summary>
		[JsonProperty("error_type")]
		public ErrorType ErrorType { get; set; }

		/// <summary>
		/// The particular error code.
		/// </summary>
		[JsonProperty("error_code")]
		public ErrorCode ErrorCode { get; set; }

		/// <summary>
		/// A developer-friendly representation of the error code.
		/// </summary>
		/// <remarks>This may change over time and is not safe for programmatic use.</remarks>
		[JsonProperty("developer_message")]
		public string DeveloperMessage { get; set; } = null!;

		/// <summary>
		/// A user-friendly representation of the error code. <c>null</c> if the error is not related to user action.
		/// </summary>
		/// <remarks>
		/// This may change over time and is not safe for programmatic use.
		/// </remarks>
		[JsonProperty("display_message")]
		public string? DisplayMessage { get; set; }

		/// <summary>
		/// A unique string identifying the request, to be used for troubleshooting purposes. 
		/// </summary>
		/// <remarks>This field will be omitted in errors provided by webhooks.</remarks>
		[JsonProperty("request_id")]
		public string? RequestId { get; set; }

		/// <summary>
		/// In the Assets product, a request can pertain to more than one Item. If an error is returned for such a request, causes will return an array of errors containing a breakdown of these errors on the individual Item level, if any can be identified.
		/// </summary>
		/// <remarks><see cref="Causes"/> will only be provided for the error type <see cref="ErrorType.AssetReportError"/>.</remarks>
		[JsonProperty("causes")]
		public IReadOnlyList<string> Causes { get; set; } = Array.Empty<string>();

		/// <summary>
		/// The HTTP status code associated with the error. 
		/// </summary>
		/// <remarks>This will only be returned in the response body when the error information is provided via a webhook.</remarks>
		[JsonProperty("status")]
		public int? StatusCode { get; set; }

		/// <summary>
		/// The URL of a Plaid documentation page with more information about the error
		/// </summary>
		[JsonProperty("documentation_url")]
		public string? DocumentationUrl { get; set; }

		/// <summary>
		/// Suggested steps for resolving the error
		/// </summary>
		[JsonProperty("suggested_action")]
		public string? SuggestedAction { get; set; }
	}
}
