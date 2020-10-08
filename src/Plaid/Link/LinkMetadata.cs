using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Going.Plaid.Entity;
using Going.Plaid.Exceptions;
using Going.Plaid.Utilities;

using Newtonsoft.Json;

namespace Going.Plaid.Link
{
	/// <summary>
	/// Encpasulates the common elements of the Plaid Link metadata returned in the Javascript Link flows.
	/// </summary>
	/// <remarks>
	/// Typically you will actually use <see cref="OnEventMetadata"/>, <see cref="OnExitMetadata"/> or <see cref="OnSuccessMetadata"/><br/>
	/// See: <see href="https://plaid.com/docs/link/web/"/>
	/// </remarks>
	public class LinkMetadata
	{

		/// <summary>
		/// Indicates of the metadata response described by this object is an Error state
		/// </summary>
		/// <returns></returns>
		public bool IsError() => ErrorType is null;


		/// <summary>
		/// In the case of an Error state, builds a PlaidException object to encapsulate the Error
		/// </summary>
		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public PlaidException? Exception => IsError() ? null : new PlaidException()
		{
			ErrorMessage = ErrorMessage ?? "",
#pragma warning disable CS8629 // Nullable value type may be null.
			ErrorCode = (ErrorCode)ErrorCode,
			ErrorType = (ErrorType)ErrorType,
#pragma warning restore CS8629 // Nullable value type may be null.
			DisplayMessage = DisplayMessage ?? ErrorMessage
		};


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		[JsonPropertyName("error_code")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("error_code")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public ErrorCode? ErrorCode { get; set; } = null!;

		[JsonPropertyName("error_message")]
		[JsonProperty("error_message")]
		public string? ErrorMessage { get; set; } = null!;

		[JsonPropertyName("error_type")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("error_type")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public ErrorType? ErrorType { get; set; } = null!;

		[JsonPropertyName("display_message")]
		[JsonProperty("display_message")]
		public string DisplayMessage { get; set; } = null!;

		[JsonPropertyName("http_code")]
		[JsonProperty("http_code")]
		public HttpStatusCode? StatusCode { get; set; }

		[JsonPropertyName("request_id")]
		[JsonProperty("request_id")]
		public string RequestId { get; set; } = null!;

		[JsonPropertyName("link_session_id")]
		[JsonProperty("link_session_id")]
		public string LinkSessionId { get; set; } = null!;

		[JsonPropertyName("timestamp")]
		[JsonProperty("timestamp")]
		public DateTime Timestamp { get; set; }
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
