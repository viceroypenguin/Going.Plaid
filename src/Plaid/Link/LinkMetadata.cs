using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Going.Plaid.Exceptions;
using Going.Plaid.Utilities;

using Newtonsoft.Json;

namespace Going.Plaid.Link
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public class LinkMetadata
	{
		public bool IsError() => ErrorType.HasValue;
		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public PlaidException? Exception => !IsError() ? null : new PlaidException(ErrorMessage ?? "")
		{
#pragma warning disable CS8601 // Possible null reference assignment.
			ErrorCode = Enum.GetName(typeof(PlaidErrorCode), (PlaidErrorCode)ErrorCode),
			ErrorType = Enum.GetName(typeof(PlaidErrorType), (PlaidErrorType)ErrorType),
			DisplayMessage = DisplayMessage ?? ErrorMessage
#pragma warning restore CS8601 // Possible null reference assignment.
		};

		[JsonPropertyName("error_code")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("error_code")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public PlaidErrorCode? ErrorCode { get; set; } = null;
		public string? ErrorCodeDescription => ErrorCode?.GetDescription();

		private string? _errorMessage;

		[JsonPropertyName("error_message")]
		[JsonProperty("error_message")]
		public string? ErrorMessage
		{
			get => _errorMessage ?? ErrorCodeDescription ?? ErrorTypeDescription;
			set => _errorMessage = value;
		}

		[JsonPropertyName("error_type")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("error_type")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public PlaidErrorType? ErrorType { get; set; } = null;

		public string? ErrorTypeDescription => ErrorType?.GetDescription();

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
