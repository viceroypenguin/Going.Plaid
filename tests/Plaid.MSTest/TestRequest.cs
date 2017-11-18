using System;
using System.Configuration;
using System.IO;

namespace Acklann.Plaid.MSTest
{
    public static class TestRequest
    {
        static TestRequest()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plaid.config");
            var config = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap() { ExeConfigFilename = configPath }, ConfigurationUserLevel.None);

            ClientId = config.AppSettings.Settings["client_id"].Value;
            Secret = config.AppSettings.Settings["secret"].Value;
        }

        public static readonly string ClientId, Secret;

        public static Connect.Request CreateConnectRequest(string bankId = BankId.Default)
        {
            var request = new Connect.Request();
            UseDefaults(request);
            request.Type = bankId;
            return request;
        }

        /* ***** Extension Methods ***** */

        public static RequestBase UseDefaults(this RequestBase request)
        {
            request.ClientId = Sandbox.ClientId;
            request.Secret = Sandbox.Secret;
            request.Username = Sandbox.StandardUsername;
            request.Password = Sandbox.GoodPassword;
            return request;
        }

        public static RequestBase UseLiveCredentials(this RequestBase request)
        {
            request.ClientId = ClientId;
            request.Secret = Secret;
            return request;
        }

        public static RequestBase UseInvalidPassword(this RequestBase request)
        {
            request.Password = Sandbox.LockedPassword;
            return request;
        }

        public static RequestBase UseMFA(this RequestBase request)
        {
            request.Username = Sandbox.MfaUsername;
            return request;
        }

        public static RequestBase UseToken(this RequestBase request, string bankId = BankId.Default)
        {
            request.AccessToken = $"test_{bankId}";
            return request;
        }

        public struct Sandbox
        {
            public static readonly int Pin = 1234;

            public static readonly string
                ClientId = "test_id",
                Secret = "test_secret",

                StandardUsername = "plaid_test",
                MfaUsername = "plaid_selections",
                GoodPassword = "plaid_good",
                LockedPassword = "plaid_locked";
        }
    }
}