using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Going.Plaid.Entity;
using Going.Plaid.Exceptions;
using Going.Plaid.Utilities;
using Newtonsoft.Json;

namespace Going.Plaid.Link
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// See: <see href="https://plaid.com/docs/link/web/#onevent"/><br/>
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
	public class OnEventMetadata
	{
		/// <summary>
		/// The Event Name is passed to the onEvent Javascript callback as a separate parameter from 
		/// the metadata structure itself. It must be manually added to the metadata in order to be 
		/// included when deserializing.<br/>
		/// <example>
		/// <code>
		///  onEvent: function(eventName, metadata)
		///  {
		///	  // Optionally capture Link flow events, streamed through
		///	  // this callback as your users connect an Item to Plaid.
		///	  // For example:
		///	  // eventName = "TRANSITION_VIEW"
		///	  // metadata  = {
		///	  //   link_session_id: "123-abc",
		///	  //   mfa_type:        "questions",
		///	  //   timestamp:       "2017-09-14T14:42:19.350Z",
		///	  //   view_name:       "MFA",
		///	  // }
		///	  console.info('onEvent:' + eventName, metadata);
		///	  metadata.event_name = eventName;
		///	  ... send the metadata as JSON to be deserialized into this class ...  
		///  }
		/// </code>
		/// </example>
		/// </summary>
		[JsonPropertyName("event_name")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("event_name")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public LinkEventName? EventName { get; set; } = null!;


		#region error_*

		/// <summary>
		/// Composes a <see cref="PlaidException"/> from the constituant properties of this 
		/// <see cref="OnEventMetadata"/> object. 
		/// </summary>
		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public PlaidException? Exception =>
			ErrorCode is null || ErrorType is null
			? null
			: new PlaidException();

		/// <summary>
		/// The error code that the user encountered.
		/// </summary>
		[JsonPropertyName("error_code")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("error_code")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public ErrorCode? ErrorCode { get; set; } = null!;

		/// <summary>
		/// The error message that the user encountered.
		/// </summary>
		[JsonPropertyName("error_message")]
		[JsonProperty("error_message")]
		public string? ErrorMessage { get; set; } = null!;

		/// <summary>
		/// The error type that the user encountered. 
		/// </summary>
		[JsonPropertyName("error_type")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("error_type")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public ErrorType? ErrorType { get; set; } = null!;

		#endregion


		/// <summary>
		/// The status key indicates the point at which the user exited the Link flow. 
		/// </summary>
		/// <remarks>See: <see cref="OnExitMetadata.Status"/></remarks>
		[JsonPropertyName("exit_status")]
		[JsonProperty("exit_status")]
		public LinkExitStatus? Status { get; set; } = null!;

		/// <summary>
		/// The ID of the selected institution. <br/>
		/// Emitted by: all events.
		/// </summary>
		[JsonPropertyName("institution_id")]
		[JsonProperty("institution_id")]
		public string InstitutionId { get; set; } = null!;

		/// <summary>
		/// The name of the selected institution. <br/>
		/// Emitted by: all events.
		/// </summary>
		[JsonPropertyName("institution_name")]
		[JsonProperty("institution_name")]
		public string InstitutionName { get; set; } = null!;

		/// <summary>
		/// The query used to search for institutions. <br/>
		/// Emitted by: SEARCH_INSTITUTION.
		/// </summary>
		[JsonPropertyName("institution_search_query")]
		[JsonProperty("institution_search_query")]
		public string InstitutionSearchQuery { get; set; } = null!;

		/// <summary>
		/// If set, the user has encountered one of the following MFA types: code, device, 
		/// questions, selections. <br/>
		/// Emitted by: SUBMIT_MFA and TRANSITION_VIEW when view_name is MFA
		/// </summary>
		[JsonPropertyName("mfa_type")]
		[JsonProperty("mfa_type")]
		public string MfaType { get; set; } = null!;

		/// <summary>
		/// The name of the view that is being transitioned to. <br/>
		/// Emitted by: TRANSITION_VIEW.
		/// </summary>
		[JsonPropertyName("view_name")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("view_name")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public LinkViewName? ViewName { get; set; } = null!;

		/// <summary>
		/// Only applicable for <see cref="PlaidErrorType.AUTH_ERROR"/>
		/// </summary>
		/// <remarks>See: <see href="https://plaid.com/docs/#auth-errors"/></remarks>
		[JsonPropertyName("account_id")]
		[JsonProperty("account_id")]
		public string AccountId { get; set; } = null!;

		/// <summary>
		/// The request ID for the last request made by Link. This can be shared with Plaid Support to expedite investigation. <br/>
		/// Emitted by: all events.
		/// </summary>
		[JsonPropertyName("request_id")]
		[JsonProperty("request_id")]
		public string RequestId { get; set; } = null!;

		/// <summary>
		/// The link_session_id is a unique identifier for a single session of Link. 
		/// It's always available and will stay constant throughout the flow. <br/>
		/// Emitted by: all events.
		/// </summary>
		[JsonPropertyName("link_session_id")]
		[JsonProperty("link_session_id")]
		public string LinkSessionId { get; set; } = null!;

		/// <summary>
		/// An ISO 8601 representation of when the event occurred. <br/>
		/// For example 2017-09-14T14:42:19.350Z. <br/>
		/// Emitted by: all events.
		/// </summary>
		[JsonPropertyName("timestamp")]
		[JsonProperty("timestamp")]
		public DateTime Timestamp { get; set; }
	}
}
