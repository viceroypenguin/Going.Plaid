using Going.Plaid.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
		[JsonProperty("status")]
		[JsonConverter(typeof(StringEnumConverter))]
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
		[JsonProperty("error")]
		public virtual PlaidException? Exception { get; set; } = null!;


		/// <summary>
		/// The request ID for the last request made by Link. This can be shared with Plaid Support to expedite investigation. <br/>
		/// Emitted by: all events.
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; } = null!;

		/// <summary>
		/// The link_session_id is a unique identifier for a single session of Link. 
		/// It's always available and will stay constant throughout the flow. <br/>
		/// Emitted by: all events.
		/// </summary>
		[JsonProperty("link_session_id")]
		public string LinkSessionId { get; set; } = null!;

		/// <summary>
		/// Gets or sets the institution.
		/// </summary>
		/// <value>The institution.</value>
		[JsonProperty("institution")]
		public InstitutionInfo Institution { get; set; } = null!;

		/// <summary>
		/// Represents an <see cref="Entity.Institution"/> metadata.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage(
			"Design",
			"CA1034:Nested types should not be visible",
			Justification = "Required for Json deserialization?")]
		public class InstitutionInfo
		{
			/// <summary>
			/// Gets or sets the <see cref="Entity.Institution"/> identifier.
			/// </summary>
			/// <value>The identifier.</value>
			[JsonProperty("institution_id")]
			public string Id { get; set; } = null!;

			/// <summary>
			/// Gets or sets the <see cref="Entity.Institution"/> name.
			/// </summary>
			/// <value>The name.</value>
			[JsonProperty("name")]
			public string Name { get; set; } = null!;
		}
	}
}
