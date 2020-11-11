using Newtonsoft.Json;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a Plaid item. A set of credentials at a financial institution.
	/// </summary>
	public class Item
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[JsonProperty("item_id")]
		public string Id { get; init; } = null!;

		/// <summary>
		/// Gets or sets the available products.
		/// </summary>
		/// <value>The available products.</value>
		[JsonProperty("available_products")]
		public string[] AvailableProducts { get; init; } = null!;

		/// <summary>
		/// Gets or sets the billed products.
		/// </summary>
		/// <value>The billed products.</value>
		[JsonProperty("billed_products")]
		public string[] BilledProducts { get; init; } = null!;

		/// <summary>
		/// Gets or sets the <see cref="Entity.Institution"/> identifier.
		/// </summary>
		/// <value>The institution identifier.</value>
		[JsonProperty("institution_id")]
		public string InstitutionId { get; init; } = null!;

		/// <summary>
		/// Gets or sets the webhook.
		/// </summary>
		/// <value>The webhook.</value>
		[JsonProperty("webhook")]
		public string? Webhook { get; init; }
	}
}
