using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Gigobyte.Plaid;
using Gigobyte.Plaid.Contract;
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
        public async Task AddUser_creates_a_new_plaid_connect_account_when_no_mfa_is_needed()
        {
            // Arrange
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret);

            // Act
            var result = await sut.AddUserAsync(new Credential(PlaidSandbox.StandardUser, PlaidSandbox.Password), "td");
            

            // Assert
        }
    }
}
