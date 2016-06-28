using System;

namespace Gigobyte.Plaid
{
    /// <summary>
    /// Provides methods to retrieve static resources and variables.
    /// </summary>
    public static class Plaid
    {
        internal static Uri GetEndpoint(Environment environment, string path, string query = null)
        {
            string host = (environment == Environment.Development ? "tartan.plaid.com" : "api.plaid.com");
            return new UriBuilder("https", host) { Path = path, Query = query }.Uri;
        }

        /// <summary>
        /// Provides methods to get an endpoint.
        /// </summary>
        public struct Endpoint
        {
            public static Uri Institution(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "institutions");
            }

            public static Uri Institution(string id, Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, $"institutions/{id}");
            }

            public static Uri InstitutionSearch(string query, Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "institutions/search", $"q={query}");
            }

            public static Uri InstitutionSearch(string query, string product, Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "institutions/search", $"q={query}&p={product}");
            }

            public static Uri Connect(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "connect");
            }

            public static Uri ConnectStep(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "connect/step");
            }

            public static Uri ConnectGet(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "connect/get");
            }

            public static Uri Balance(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "balance");
            }
        }
    }
}