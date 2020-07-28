using Going.Plaid.Entity;
using Newtonsoft.Json;

namespace Going.Plaid.Institution
{
	/// <summary>
	/// Represents a response from plaid's '<c>/institutions/search</c>' endpoints. The '<c>/institutions/search</c>' endpoint to retrieve a complete list of supported institutions that match the query.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class SearchResponse : ResponseBase
	{
		/// <summary>
		/// The list of institutions returned by the server.
		/// </summary>
		[JsonProperty("institutions")]
		public Entity.Institution[] Institutions { get; set; } = null!;
	}
}
