using System;

namespace Gigobyte.Plaid.Exceptions
{
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

        public PlaidException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        public ResponseCode StatusCode
        {
            get { return ErrorCode.AsResponseCode(); }
        }

        public int ErrorCode { get; internal set; }
    }
}