namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a request for plaid's '/item/delete' endpoints. The '/item/delete' endpoint allows you to delete an <see cref="Entity.Item"/>. Once deleted, the access_token associated with the Item is no longer valid and cannot be used to access any data that was associated with the <see cref="Entity.Item"/>.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.RequestBase" />
    public class DeleteItemRequest : RequestBase { }
}