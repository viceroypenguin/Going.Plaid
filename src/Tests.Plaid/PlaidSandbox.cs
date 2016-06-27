using Gigobyte.Plaid.Contract;

namespace Tests.Plaid
{
    public class PlaidSandbox
    {
        public const string
            ClientId = "test_id",
            Secret = "test_secret",
            StandardUser = "plaid_test",
            MfaUser = "plaid_selections",
            Password = "plaid_good",
            LockedPassword = "plaid_locked",
            Pin = "1234";

        public struct Institution
        {
            public const string Chase = "chase";
            public const string BancoPopular = "1437";
            public const string BankOfAmerica = "bofa";
            public const string AmericanExpress = "amex";
        }
    }
}