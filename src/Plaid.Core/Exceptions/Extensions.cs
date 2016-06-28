namespace Gigobyte.Plaid.Exceptions
{
    /// <summary>
    /// Provides extension methods for the <see cref="Exceptions"/> namespace.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts to an integer to a plaid <see cref="ResponseCode"/>.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns>ResponseCode.</returns>
        public static ResponseCode ConvertToResponseCode(this int code)
        {
            switch (code)
            {
                case 200:
                    return ResponseCode.Success;

                case 201:
                    return ResponseCode.MfARequired;

                case 400:
                    return ResponseCode.BadRequest;

                case 401:
                    return ResponseCode.Unauthorized;

                case 402:
                    return ResponseCode.RequestFailed;

                case 404:
                    return ResponseCode.NotFound;

                default:
                    if (code >= 1000) return ResponseCode.BadRequest;
                    else if (code >= 1100) return ResponseCode.Unauthorized;
                    else if (code >= 1200) return ResponseCode.UserAuthenticationInvalid;
                    else if (code >= 1300) return ResponseCode.InstitutionsError;
                    else if (code >= 1400) return ResponseCode.EntitiesError;
                    else if (code >= 1500) return ResponseCode.CategoriesError;
                    else if (code >= 1600) return ResponseCode.ItemMissing;
                    else if (code >= 1700) return ResponseCode.ServerError;
                    else if (code >= 1800) return ResponseCode.PlannedMaintenance;
                    else return ResponseCode.ServerError;
            }
        }
    }
}