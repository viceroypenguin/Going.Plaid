using System;
using Going.Plaid.Options;
using Newtonsoft.Json;

namespace Going.Plaid.Institution
{
	/// <summary>
	/// Represents a request for plaid's '<c>/institutions/search</c>' endpoints. The '<c>/institutions/search</c>' endpoint to retrieve a complete list of supported institutions that match the query.
	/// </summary>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class SearchRequest : RequestBase
	{
		/// <summary>
		/// Gets or sets the query.
		/// </summary>
		/// <remarks>Required</remarks>
		[JsonProperty("query")]
		public string Query { get; set; } = null!;

		/// <summary>
		/// Gets or sets the supported products.
		/// </summary>
		/// <remarks>Required</remarks>
		[JsonProperty("products")]
		public string[] Products { get; set; } = null!;

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("options")]
		public InstitutionSearchOptions? Options { get; set; }
	}
}
