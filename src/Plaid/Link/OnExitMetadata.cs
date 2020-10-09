﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Going.Plaid.Exceptions;
using Going.Plaid.Management;
using Going.Plaid.Utilities;
using Newtonsoft.Json;

namespace Going.Plaid.Link
{
	/// <summary>
	/// Provides a data structure to use to deserialize the Plaid JSON metadata returned when the onExit event
	/// in the Plaid Link flow is triggered.
	/// </summary>
	public class OnExitMetadata
	{
		/// <summary>
		/// Describes the step in the Plaid Link flow where the user exited the flow.
		/// </summary>
		[JsonPropertyName("status")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("status")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public LinkExitStatus? Status { get; set; } = null!;

		/// <summary>
		/// In the case of an Error state, a <see cref="PlaidException"/> object encapsulating the Error.<br/>
		/// The error structure is passed to the onExit separately and must be manually added to 
		/// the metadata JSON before sending for deserialization.
		/// <example>
		/// <code>
		///    onExit: async function(err, metadata)
		///    {
		///	    // error = {
		///	    //  display_message: "The credentials were ...",
		///	    //  error_code: "INVALID_CREDENTIALS",
		///	    //  error_message: "the credentials were ...",
		///	    //  error_type: "ITEM_ERROR",
		///	    // }
		///	    // metadata = {
		///	    //  link_session_id: "dc21685c-192e-4969-b4e9-bab890daae31",
		///	    //  institution: {
		///	    //   name: "Wells Fargo",
		///	    //   institution_id: "ins_4"
		///	    //  },
		///	    //  status: "requires_credentials"
		///	    // }
		///
		///	    // metadata contains information about the institution
		///	    // that the user selected and the most recent API request IDs.
		///	    // Storing this information can be helpful for support.
		///	    if (err != null)
		///	    {
		///		    metadata.error = err;
		///	    }
		///	    
		///	    ... send the metadata as JSON to be deserialized into this class ... 
		///	  } 
		/// </code>
		/// </example>
		/// </summary>
		[JsonPropertyName("error")]
		[JsonProperty("error")]
		public virtual PlaidException? Exception { get; set; } = null!;


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
		/// Gets or sets the institution.
		/// </summary>
		/// <value>The institution.</value>
		[JsonPropertyName("institution")]
		[JsonProperty("institution")]
		public InstitutionInfo Institution { get; set; } = null!;

		/// <summary>
		/// Represents an <see cref="Entity.Institution"/> metadata.
		/// </summary>
		public class InstitutionInfo
		{
			/// <summary>
			/// Gets or sets the <see cref="Going.Plaid.Entity.Institution"/> identifier.
			/// </summary>
			/// <value>The identifier.</value>
			[JsonPropertyName("institution_id")]
			[JsonProperty("institution_id")]
			public string Id { get; set; } = null!;

			/// <summary>
			/// Gets or sets the <see cref="Going.Plaid.Entity.Institution"/> name.
			/// </summary>
			/// <value>The name.</value>
			[JsonPropertyName("name")]
			[JsonProperty("name")]
			public string Name { get; set; } = null!;
		}
	}
}
