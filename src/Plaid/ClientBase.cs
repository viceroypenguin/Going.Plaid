using System;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Acklann.Plaid
{
    public abstract class ClientBase
    {
        public ClientBase(string clientId, string secret, bool development)
        {
            Secret = secret;
            ClientId = clientId;
            _endpoint = new UriBuilder()
            {
                Scheme = Uri.UriSchemeHttps,
                Host = $"{(development ? "tartan." : string.Empty)}plaid.com"
            };
        }

        public string Secret { get; set; }

        public string ClientId { get; set; }

        protected virtual string GetEndpoint(string path)
        {
            _endpoint.Path = path;
            return _endpoint.Uri.AbsoluteUri;
        }

        protected virtual void Validate(RequestBase request)
        {
            if (string.IsNullOrEmpty(request.Secret)) request.Secret = Secret;
            if (string.IsNullOrEmpty(request.ClientId)) request.ClientId = ClientId;
        }

        protected virtual StringContent CreateBody(string json)
        {
            return new StringContent(json, Encoding.UTF8, _contentType);
        }

        #region Private Members

        private readonly UriBuilder _endpoint;
        private readonly string _contentType = "application/json";

        internal static void Debug(string json, string title = "POST-REQUEST")
        {
            string line = string.Concat(Enumerable.Repeat('-', (50 - title.Length + 2)));
            line.Insert(5, $" {title} ");

            System.Diagnostics.Debug.WriteLine(line);
            System.Diagnostics.Debug.WriteLine(json);
        }

        #endregion Private Members
    }
}