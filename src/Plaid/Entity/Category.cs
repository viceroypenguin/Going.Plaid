using System.Text.Json.Serialization;

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
		[JsonPropertyName("category_id")]
		public string CategoryId { get; init; } = null!;

		/// <summary>
		/// Gets or sets the group.
		/// </summary>
		[JsonPropertyName("group")]
		public string Group { get; init; } = null!;

		/// <summary>
		/// Gets or sets the hierarchy or sub-categories.
		/// </summary>
		[JsonPropertyName("hierarchy")]
		public string[] Hierarchy { get; init; } = null!;
	}
}
