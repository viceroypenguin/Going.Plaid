using Newtonsoft.Json;

namespace Gigobyte.Plaid.Model
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

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}