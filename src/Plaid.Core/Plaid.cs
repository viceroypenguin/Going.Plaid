using System;

namespace Gigobyte.Plaid
{
    /// <summary>
    /// Provides methods to retrieve static resources and variables.
    /// </summary>
    public static class Plaid
    {
        /// <summary>
        /// Creates a plaid endpoint.
        /// </summary>
        /// <param name="environment">The environment.</param>
        /// <param name="path">The path.</param>
        /// <param name="queryString">The query string.</param>
        /// <returns>The endpoint.</returns>
        internal static Uri GetEndpoint(Environment environment, string path, string queryString = null)
        {
            string host = (environment == Environment.Development ? "tartan.plaid.com" : "api.plaid.com");
            return new UriBuilder("https", host) { Path = path, Query = queryString }.Uri;
        }

        /// <summary>
        /// Provides methods to get an endpoint.
        /// </summary>
        public struct Endpoint
        {
            /// <summary>
            /// Get the '/institutions' endpoint.
            /// </summary>
            /// <param name="environment">The environment.</param>
            /// <returns>The 'institutions' endpoint.</returns>
            /// <example>https://api.plaid.com/institutions</example>
            public static Uri Institution(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "institutions");
            }

            /// <summary>
            /// Get the '/institutions/&lt;id&gt;' endpoint.
            /// </summary>
            /// <param name="id">The identifier.</param>
            /// <param name="environment">The environment.</param>
            /// <returns>The 'institution/&lt;id&gt;' endpoint.</returns>
            /// <example>https://api.plaid.com/institutions/1234</example>
            public static Uri Institution(string id, Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, $"institutions/{id}");
            }

            /// <summary>
            /// Get the '/institutions/search' endpoint.
            /// </summary>
            /// <param name="query">The query.</param>
            /// <param name="environment">The environment.</param>
            /// <returns>The 'institutions/search' endpoint.</returns>
            /// <example>https://api.plaid.com/institutions/search?q=chase</example>
            public static Uri InstitutionSearch(string query, Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "institutions/search", $"q={query}");
            }

            /// <summary>
            /// Get the '/institutions/search' endpoint.
            /// </summary>
            /// <param name="query">The query.</param>
            /// <param name="product">The product.</param>
            /// <param name="environment">The environment.</param>
            /// <returns>The 'institutions/search' endpoint.</returns>
            /// <example>https://api.plaid.com/institutions/search?q=chase&amp;p=connect</example>
            public static Uri InstitutionSearch(string query, string product, Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "institutions/search", $"q={query}&p={product}");
            }

            /// <summary>
            /// Get the '/connect' endpoint.
            /// </summary>
            /// <param name="environment">The environment.</param>
            /// <returns>The 'connect' endpoint.</returns>
            /// <example>https://api.plaid.com/institutions/connect</example>
            public static Uri Connect(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "connect");
            }

            /// <summary>
            /// Get the '/connect/step' endpoint.
            /// </summary>
            /// <param name="environment">The environment.</param>
            /// <returns>The 'connect/step' endpoint.</returns>
            /// <example>https://api.plaid.com/institutions/connect/step</example>
            public static Uri ConnectStep(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "connect/step");
            }

            /// <summary>
            /// Get the '/connect/get' endpoint.
            /// </summary>
            /// <param name="environment">The environment.</param>
            /// <returns>The 'connect/get' endpoint.</returns>
            /// <example>https://api.plaid.com/institutions/connect/get</example>
            public static Uri ConnectGet(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "connect/get");
            }

            /// <summary>
            /// Get the '/balance' endpoint.
            /// </summary>
            /// <param name="environment">The environment.</param>
            /// <returns>The 'balance' endpoint.</returns>
            /// <example>https://api.plaid.com/balance</example>
            public static Uri Balance(Environment environment = Environment.Production)
            {
                return GetEndpoint(environment, "balance");
            }
        }
    }
}