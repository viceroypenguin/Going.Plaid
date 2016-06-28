namespace Gigobyte.Plaid.Exceptions
{
    /// <summary>
    /// An plaid response code.
    /// </summary>
    public enum ResponseCode
    {
        /// <summary>
        /// 200: Success.
        /// </summary>
        Success = 200,

        /// <summary>
        /// 201: MFA Required.
        /// </summary>
        MfARequired = 201,

        /// <summary>
        /// 400: Bad Request.
        /// </summary>
        BadRequest = 400,

        /// <summary>
        /// 401: Unauthorized.
        /// </summary>
        Unauthorized = 401,

        /// <summary>
        /// 402: Request Failed.
        /// </summary>
        RequestFailed = 402,

        /// <summary>
        /// 404: Cannot be Found.
        /// </summary>
        NotFound = 404,

        /// <summary>
        /// The server error.
        /// </summary>
        ServerError = 500,

        /// <summary>
        /// 120X: User Authentication Invalid.
        /// </summary>
        UserAuthenticationInvalid = 1200,

        /// <summary>
        /// 130X: Institutions Error.
        /// </summary>
        InstitutionsError = 1300,

        /// <summary>
        /// 140X: Entities Error.
        /// </summary>
        EntitiesError = 1400,

        /// <summary>
        /// 150X: Categories Error.
        /// </summary>
        CategoriesError = 1500,

        /// <summary>
        /// 160X: Item Missing.
        /// </summary>
        ItemMissing = 1600,

        /// <summary>
        /// 180X: Planned Maintenance.
        /// </summary>
        PlannedMaintenance = 1800
    }
}