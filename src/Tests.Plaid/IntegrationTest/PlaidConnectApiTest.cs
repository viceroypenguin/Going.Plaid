using ApprovalTests.Namers;
using Gigobyte.Plaid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Tests.Plaid.IntegrationTest
{
    [TestClass]
    [UseApprovalSubdirectory(nameof(ApprovalTests))]
    public class PlaidConnectApiTest
    {
        internal Environment Environment = Environment.Development;

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        public async Task AddUser_creates_a_new_plaid_connect_account_when_no_mfa_is_needed()
        {
            // Arrange
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret, Environment);

            // Act
            var response = await sut.AddUserAsync(PlaidSandbox.StandardUser, PlaidSandbox.Password, "amex");

            // Assert
            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.IsNull(response.Transactions);
            Assert.IsNull(response.Mfa);
        }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        public async Task AddUser_creates_a_new_plaid_connect_account_when_question_based_mfa_is_needed()
        {
            // Arrange
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret, Environment);

            // Act
            var response = await sut.AddUserAsync(PlaidSandbox.StandardUser, PlaidSandbox.Password, "td");

            // Assert
            Assert.AreEqual(201, (int)response.StatusCode);
            Assert.IsNull(response.Transactions);
            Assert.IsNotNull(response.Mfa);
        }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        public async Task AddUser_creates_a_new_plaid_connect_account_when_code_based_mfa_is_needed()
        {
            // Arrange
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret, Environment);

            // Act
            var response = await sut.AddUserAsync(PlaidSandbox.StandardUser, PlaidSandbox.Password, "chase");

            // Assert
            Assert.AreEqual(201, (int)response.StatusCode);
            Assert.IsNull(response.Transactions);
            Assert.IsNotNull(response.Mfa);
        }
    }
}