using System.Text.Json.Serialization;
using Going.Plaid.Entity;

namespace Going.Plaid.Sandbox
{
	/// <summary>
	/// Represents a request for plaid's '<c>/sandbox/public_token/create</c>' endpoint.
	/// Used to create a valid <c>public_token</c> in testing workflows, without initiate Link UI.
	/// </summary>
	/// <seealso cref="RequestBase" />
	public class CreatePublicTokenRequest : RequestBase
	{
		/// <summary>
		/// A list of Plaid product(s) you wish to use.
		/// </summary>
		[JsonPropertyName("initial_products")]
		public Product[] InitialProducts { get; set; } = null!;
		
		/// <summary>
		/// The ID of the <see cref="Institution"/> the <see cref="Item"/> will be associated with
		///
		/// the Item will be associated with
		/// </summary>
		[JsonPropertyName("institution_id")]
		public string InstitutionId { get; init; } = null!;
		
	}
}
