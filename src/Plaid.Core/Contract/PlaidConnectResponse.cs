using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents a response message of the Plaid Connect endpoint.
    /// </summary>
    [JsonObject]
    public class PlaidConnectResponse : PlaidResponseBase
    {
        /// <summary>
        /// Gets or sets the user's accounts.
        /// </summary>
        /// <value>The accounts.</value>
        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }

        /// <summary>
        /// Gets or sets the user's transactions.
        /// </summary>
        /// <value>The transactions.</value>
        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the MFA requirements.
        /// </summary>
        /// <value>The MFA.</value>
        [JsonProperty("mfa")]
        public JToken Mfa { get; set; }

        /// <summary>
        /// Gets or sets the type of MFA.
        /// </summary>
        /// <value>The MFA type.</value>
        [JsonProperty("type")]
        public string MfaTypeId { get; set; }

        /// <summary>
        /// Gets the type of the MFA.
        /// </summary>
        /// <value>The MFA type.</value>
        public MfaType MfaType
        {
            get { return MfaTypeId.AsMfaType(); }
        }

        public bool CheckForMfaConfirmation(out string message)
        {
            if (Mfa.HasValues && MfaTypeId.Equals("device", StringComparison.CurrentCultureIgnoreCase))
            {
                message = Mfa["message"].Value<string>();
                return true;
            }
            else
            {
                message = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Gets the security question(s) to be answered for MFA.
        /// </summary>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public IEnumerable<string> GetSecurityQuestions()
        {
            if (Mfa.HasValues && (MfaTypeId.AsMfaType() == MfaType.Question))
            {
                foreach (var item in Mfa.Value<JArray>())
                {
                    if (item.HasValues) yield return item["question"].Value<string>();
                }
            }
        }

        /// <summary>
        /// Gets the authentication methods that can be used for MFA.
        /// </summary>
        /// <returns>IEnumerable&lt;DeliveryOption&gt;.</returns>
        public IEnumerable<AuthenticationMethod> GetAuthenticationMethods()
        {
            if (Mfa.HasValues && (MfaTypeId.AsMfaType() == MfaType.Code))
            {
                foreach (var item in Mfa.Value<JArray>())
                {
                    if (item.HasValues) yield return item.ToObject<AuthenticationMethod>();
                }
            }
        }
    }
}