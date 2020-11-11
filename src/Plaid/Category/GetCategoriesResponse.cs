namespace Going.Plaid.Category
{
	/// <summary>
	/// Represents a response from plaid's '<c>/categories/get</c>' endpoint. Send a request to the '<c>/categories/get</c>' endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.
	/// </summary>
	/// <seealso cref="ResponseBase" />
	public record GetCategoriesResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the categories.
		/// </summary>
		/// <value>The categories.</value>
		public Entity.Category[] Categories { get; init; } = null!;
	}
}
