namespace Going.Plaid.Category
{
    /// <summary>
    /// Represents a request for plaid's '<c>/categories/get</c>' endpoint. Send a request to the '<c>/categories/get</c>' endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.
    /// </summary>
    /// <seealso cref="Going.Plaid.SerializableContent" />
    public class GetCategoriesRequest : SerializableContent { }
}