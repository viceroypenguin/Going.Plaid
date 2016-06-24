using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gigobyte.Plaid.Contract
{
    public abstract class PlaidResponseBase
    {
        /// <summary>
        /// Gets or sets the HTTP status code.
        /// </summary>
        /// <value>The HTTP status code.</value>
        public System.Net.HttpStatusCode StatusCode { get; set; }

        

       
    }
}