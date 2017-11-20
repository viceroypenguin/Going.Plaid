using Newtonsoft.Json;
using System;

namespace Acklann.Plaid.Exceptions
{
    [Serializable]
    public class PlaidException : Exception
    {
        public PlaidException()
        {
        }

        public PlaidException(string message) : base(message)
        {
        }

        public PlaidException(string message, Exception inner) : base(message, inner)
        {
        }

        protected PlaidException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        [JsonProperty("error_type")]
        public string ErrorType { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("display_message")]
        public string DisplayMessage { get; set; }
    }
}