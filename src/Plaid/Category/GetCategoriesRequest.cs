namespace Acklann.Plaid.Category
{
    /// <summary>
    /// Represents a request for plaid's '/categories/get' endpoint. Send a request to the '/categories/get' endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.SerializableContent" />
    public class GetCategoriesRequest : SerializableContent { }
}