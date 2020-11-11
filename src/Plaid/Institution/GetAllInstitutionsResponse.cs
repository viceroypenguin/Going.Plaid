using System.Text.Json.Serialization;

namespace Going.Plaid.Institution
{
	/// <summary>
	/// Represents a response from plaid's '<c>/institutions/get</c>' endpoint. Returns a JSON response containing details on all financial institutions currently supported by Plaid. Because we support thousands of institutions, results are paginated.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record GetAllInstitutionsResponse : ResponseBase
	{
		/// <summary>
		/// The list of institutions returned by the server.
		/// </summary>
		[JsonPropertyName("institutions")]
		public Entity.Institution[] Institutions { get; init; } = null!;
	}
}
