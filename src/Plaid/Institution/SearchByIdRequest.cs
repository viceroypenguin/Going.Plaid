using Going.Plaid.Options;
using Newtonsoft.Json;

namespace Going.Plaid.Institution
{
	/// <summary>
	/// Represents a request for plaid's '<c>/institutions/get_by_id</c>' endpoint. The '<c>/institutions/get_by_id</c>' endpoint to retrieve a <see cref="Entity.Institution"/> with the specified id.
	/// </summary>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class SearchByIdRequest : RequestBase
	{
		/// <summary>
		/// The identifier of the <see cref="Entity.Institution"/> for which to query information.
		/// </summary>
		/// <value>The products.</value>
		[JsonProperty("institution_id")]
		public string InstitutionId { get; set; } = null!;

		/// <summary>
		/// Options for searching Institutions
		/// </summary>
		[JsonProperty("options")]
		public InstitutionSearchOptions? Options { get; set; }
	}
}
