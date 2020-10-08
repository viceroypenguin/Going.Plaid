using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Going.Plaid.Management;
using Going.Plaid.Utilities;
using Newtonsoft.Json;

namespace Going.Plaid.Link
{
	/// <summary>
	/// Provides a data structure to use to deserialize the Plaid JSON metadata returned when the onExit event
	/// in the Plaid Link flow is triggered.
	/// </summary>
	/// <remarks>
	/// <example>
	/// Reference JSON for building this object:
	/// <code>
	/// {
	///   "link_session_id": String,
	///   "request_id": String,
	///   "institution": {
	///     "name": String,
	///     "institution_id": String
	///   },
	///   "status": String
	/// }
	/// </code>
	/// </example>
	/// </remarks>
	public class OnExitMetadata : LinkMetadata
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
		/// Contains text describing the <see cref="Status"/> value.
		/// </summary>
		public string? StatusDescription => Status?.GetDescription();

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
