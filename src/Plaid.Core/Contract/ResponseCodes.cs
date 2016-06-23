namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Plaid HTTP response codes
    /// </summary>
    public enum ResponseCodes
    {
        /// <summary>
        /// 200: Success.
        /// </summary>
        Success = 200,

        /// <summary>
        /// 201: MFA Required.
        /// </summary>
        MfaRequired = 201,

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
        CannotBeFound = 404
    }
}