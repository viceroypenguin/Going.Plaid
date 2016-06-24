using System;

namespace Gigobyte.Plaid
{
    public static class Plaid
    {
        internal static Uri GetEndpoint(Environment environment, string path)
        {
            string host = (environment == Environment.Development ? "tartan.plaid.com" : "api.plaid.com");
            return new UriBuilder("https", host) { Path = path }.Uri;
        }

        /// <summary>
        /// The Plaid API HTTP response codes.
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
            NotFound = 404
        }

        public struct Endpoint
        {
            public static string Institution(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "institution").AbsoluteUri;
            }

            public static string Connect(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "connect").AbsoluteUri;
            }

            public static string ConnectStep(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "connect/step").AbsoluteUri;
            }
        }
    }
}