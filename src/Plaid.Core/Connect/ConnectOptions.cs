using Newtonsoft.Json;
using System;

namespace Gigobyte.Plaid.Contract
{
    public class ConnectOptions
    {
       
        /// <summary>
        /// Gets or sets the web hook.
        /// </summary>
        /// <value>The web hook.</value>
        /// <remarks>
        /// Only relevant if login_only is true. This web hook will be hit when the users'
        /// transactions have finished processing.
        /// </remarks>
        [JsonProperty("webhook")]
        public string WebHook { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether pending transactions should be returned.
        /// </summary>
        /// <value><c>true</c> if pending; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// If set to true, pending transactions will be returned. Pending transactions will
        /// generally show up as posted within one to three business days, depending on the type of
        /// transaction - though some transactions may never post. Currently, new transaction IDs
        /// will be generated for all posted transactions.
        /// </remarks>
        [JsonProperty("pending")]
        public bool Pending { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [login only].
        /// </summary>
        /// <value><c>true</c> if [login only]; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// This option is valid for the initial authentication only. If set to <c>false</c>, the
        /// initial /connect request will return transaction data based on the <see
        /// cref="StartDate"/> and <see cref="EndDate"/> specified.
        /// </remarks>
        [JsonProperty("login_only")]
        public bool LoginOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="PlaidConnectRequest"/> will list
        /// the available delivery methods for code-based MFA.
        /// </summary>
        /// <value><c>true</c> if list; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// If the institution requires a code-based MFA credential, this option will list the
        /// available send methods. For example, Email (ex a...z@plaid.com), Text (ex 123-...-4321).
        /// See https://plaid.com/docs/api/#connect-mfa for more details.
        /// </remarks>
        [JsonProperty("list")]
        public bool List { get; set; }

        /// <summary>
        /// Gets or sets the start date from which to return transactions. ISO 8601 dates are
        /// accepted, e.g. '2016-03-01'. It is strongly recommended that you do not pull more than 60 days.
        /// </summary>
        /// <value>The start date.</value>
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; } = DateTime.Now.Subtract(TimeSpan.FromDays(30));

        /// <summary>
        /// Gets or sets the end date to which transactions will be collected.
        /// </summary>
        /// <value>The end date.</value>
        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}