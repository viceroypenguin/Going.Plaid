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
	/// <pre>
	/// {
	///   "link_session_id": String,
	///   "request_id": String,
	///   "institution": {
	///     "name": String,
	///     "institution_id": String
	/// },
	///   "status": String
	/// }
	/// </pre>
	/// </summary>
	public class OnExitMetadata : LinkMetadata
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		[JsonPropertyName("status")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
		[JsonProperty("status")]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public LinkExitStatus? Status { get; set; } = null!;

		public string? StatusDescription => Status?.GetDescription();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

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
