namespace Acklann.Plaid.Category
{
    /// <summary>
    /// Represents a response from plaid's '/categories/get' endpoint. Send a request to the '/categories/get' endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class GetCategoriesResponse : ResponseBase
    {
        public Entity.Category[] Categories { get; set; }
    }
}