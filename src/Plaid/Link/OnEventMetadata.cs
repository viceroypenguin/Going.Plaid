using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Going.Plaid.Utilities;
using Newtonsoft.Json;

namespace Going.Plaid.Link
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// <example>
	/// Reference JSON for building this object:
	/// <code>
	/// {
	///   "error_code": String,
	///   "error_message": String,
	///   "error_type": String,
	///   "exit_status": String,
	///   "institution_id": String,
	///   "institution_name": String,
	///   "institution_search_query": String,
	///   "link_session_id": String,
	///   "mfa_type": String,
	///   "request_id": String,
	///   "timestamp": String,
	///   "view_name": String
	/// }
	/// </code>
	/// </example>
	/// </remarks>
	public class OnEventMetadata : LinkMetadata
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		[JsonPropertyName("event_name")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("event_name")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public LinkEventName? EventName { get; set; } = null!;

		public string? EventDescription => EventName?.GetDescription();

		[JsonPropertyName("institution_id")]
		[JsonProperty("institution_id")]
		public string InstitutionId { get; set; } = null!;

		[JsonPropertyName("institution_name")]
		[JsonProperty("institution_name")]
		public string InstitutionName { get; set; } = null!;

		[JsonPropertyName("institution_search_query")]
		[JsonProperty("institution_search_query")]
		public string InstitutionSearchQuery { get; set; } = null!;

		[JsonPropertyName("mfa_type")]
		[JsonProperty("mfa_type")]
		public string MfaType { get; set; } = null!;

		[JsonPropertyName("view_name")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("view_name")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public LinkViewName? ViewName { get; set; } = null!;

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		/// <summary>
		/// Only applicable for <see cref="PlaidErrorType.AUTH_ERROR"/>
		/// </summary>
		/// <remarks>See: <see href="https://plaid.com/docs/#auth-errors"/></remarks>
		[JsonPropertyName("account_id")]
		[JsonProperty("account_id")]
		public string AccountId { get; set; } = null!;


	}
}
