namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a response from plaid's '/item/get' endpoint. The POST /item/get endpoint returns information about the status of an <see cref="Entity.Item"/>.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class GetItemResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        public Entity.Item Item { get; set; }
    }
}