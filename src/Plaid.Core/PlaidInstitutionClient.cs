using Gigobyte.Plaid.Contract;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gigobyte.Plaid
{
    public class PlaidInstitutionClient
    {
        public PlaidInstitutionClient(Environment environment = Environment.Production)
        {
            _environment = environment;
        }

        public async Task<Institution> RetrieveInstitutionAsync(string id)
        {
            using (var http = new HttpClient())
            {
                Uri url = Plaid.Endpoint.Institution(id, _environment);
                HttpResponseMessage response = await http.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
#if DEBUG
                    System.Diagnostics.Debug.WriteLine("response");
                    System.Diagnostics.Debug.WriteLine("---------------");
                    System.Diagnostics.Debug.WriteLine(responseContent);
#endif
                    return JsonConvert.DeserializeObject<Institution>(responseContent);
                }
                else throw new HttpRequestException(response.ReasonPhrase);
            }
        }

        public async Task<Institution[]> LookupInstitutionAsync(string name)
        {
            using (var http = new HttpClient())
            {
                Uri uri = Plaid.Endpoint.InstitutionSearch(name, _environment);
                var response = await http.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
#if DEBUG
                    System.Diagnostics.Debug.WriteLine("response");
                    System.Diagnostics.Debug.WriteLine("---------------");
                    System.Diagnostics.Debug.WriteLine(responseContent);
#endif
                    return JsonConvert.DeserializeObject<Institution[]>(responseContent);
                }
                else throw new HttpRequestException(response.ReasonPhrase);
            }
        }

        #region Private Members

        private readonly Environment _environment;

        #endregion Private Members
    }
}