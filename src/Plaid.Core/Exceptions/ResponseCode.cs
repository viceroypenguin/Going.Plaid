namespace Gigobyte.Plaid.Exceptions
{
    public enum ResponseCode
    {
        Success = 200,
        MfARequired = 201,
        BadRequest = 400,
        Unauthorized = 401,
        RequestFailed = 402,
        NotFound = 404,
        ServerError = 500,

        UserAuthenticationInvalid = 1200,
        InstitutionsError = 1300,
        EntitiesError = 1400,
        CategoriesError = 1500,
        ItemMissing = 1600,
        PlannedMaintenance = 1800
    }
}