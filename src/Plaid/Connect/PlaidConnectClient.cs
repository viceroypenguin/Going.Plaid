using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Acklann.Plaid.Connect
{
    public class PlaidConnectClient : ClientBase
    {
        public PlaidConnectClient(bool development = false) : this(string.Empty, string.Empty, development)
        {
        }

        public PlaidConnectClient(string clientId, string secret, bool development = false) : base(clientId, secret, development)
        {
        }

        public Response AddUser(Request request)
        {
            return AddUserAsync(request).Result;
        }

        public async Task<Response> AddUserAsync(Request request)
        {
            Validate(request);

            using (var http = new HttpClient())
            {
                string json = request.ToJson();
#if DEBUG
                Debug(json);
#endif
                using (HttpResponseMessage response = await http.PostAsync(GetEndpoint("connect"), CreateBody(json)))
                {
                    response.EnsureSuccessStatusCode();
                    return JsonConvert.DeserializeObject<Response>(await response.Content.ReadAsStringAsync());
                }
            }
        }
    }
}