using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    public class Credential
    {
        public Credential()
        {
        }

        public Credential(string username, string password)
        {
            Username = username;
            Password = password;
        }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}