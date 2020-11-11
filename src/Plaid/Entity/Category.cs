using Newtonsoft.Json;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a transaction's category.
	/// </summary>
	public class Category
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		[JsonProperty("category_id")]
		public string CategoryId { get; init; } = null!;

		/// <summary>
		/// Gets or sets the group.
		/// </summary>
		[JsonProperty("group")]
		public string Group { get; init; } = null!;

		/// <summary>
		/// Gets or sets the hierarchy or sub-categories.
		/// </summary>
		[JsonProperty("hierarchy")]
		public string[] Hierarchy { get; init; } = null!;
	}
}
