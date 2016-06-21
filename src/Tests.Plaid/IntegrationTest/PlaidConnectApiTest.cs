using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Gigobyte.Plaid;
using Gigobyte.Plaid.Model;
using ApprovalTests.Namers;

namespace Tests.Plaid.IntegrationTest
{
    [TestClass]
    [UseApprovalSubdirectory(nameof(ApprovalTests))]
    public class PlaidConnectApiTest
    {
        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        public void AddUser_creates_a_new_plaid_connect_user_account_when_invoked()
        {
            // Arrange
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret)
            {
                Type = "amex",
                Credential = new Credential(PlaidSandbox.StandardUser, PlaidSandbox.Password)
            };

            // Act
            

            // Assert
        }
    }
}
