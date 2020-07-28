namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/item/get</c>' endpoint. The POST <c>/item/get</c> endpoint returns information about the status of an <see cref="Entity.Item"/>.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class GetItemResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the item.
		/// </summary>
		/// <value>The item.</value>
		public Entity.Item Item { get; set; } = null!;
	}
}
