using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents an user's username and password.
    /// </summary>
    public class Credential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credential"/> class.
        /// </summary>
        public Credential()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credential"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public Credential(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}