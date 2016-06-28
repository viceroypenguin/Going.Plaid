using ApprovalTests.Namers;
using Gigobyte.Plaid;
using Gigobyte.Plaid.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests.Plaid.IntegrationTests
{
    [TestClass]
    [UseApprovalSubdirectory(nameof(ApprovalTests))]
    public class PlaidConnectClientTest
    {
        internal Gigobyte.Plaid.Environment Environment = Environment.Development;

        public TestContext TestContext { get; set; }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        [TestProperty(_institution, PlaidSandbox.Institution.AmericanExpress)]
        public async Task AddUserAsync_should_creates_a_connect_account_when_no_mfa_is_needed()
        {
            // Arrange
            var institution = TestContext.Properties[_institution].ToString();
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret, Environment);

            // Act
            var response = await sut.AddUserAsync(PlaidSandbox.StandardUser, PlaidSandbox.Password, institution);

            // Assert
            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.IsNull(response.Transactions);
            Assert.IsNull(response.Mfa);
        }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        [TestProperty(_institution, PlaidSandbox.Institution.BankOfAmerica)]
        public async Task AddUserAsync_should_detect_a_question_based_mfa_is_needed()
        {
            // Arrange
            var institution = TestContext.Properties[_institution].ToString();
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret, Environment);

            // Act
            var response = await sut.AddUserAsync(PlaidSandbox.StandardUser, PlaidSandbox.Password, institution);

            // Assert
            Assert.IsNotNull(response.Mfa);
            Assert.AreEqual(201, (int)response.StatusCode);
            Assert.AreEqual(AuthenticationMethod.SecurityQuestions, response.MfaType);
        }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        [TestProperty(_institution, PlaidSandbox.Institution.Chase)]
        public async Task AddUserAsync_should_detect_a_code_based_mfa_is_needed()
        {
            // Arrange
            var options = new ConnectOptions() { List = true };
            var institution = TestContext.Properties[_institution].ToString();
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret, Environment);

            // Act
            var response = await sut.AddUserAsync(PlaidSandbox.StandardUser, PlaidSandbox.Password, institution, options);

            // Assert
            Assert.IsNotNull(response.Mfa);
            Assert.AreEqual(201, (int)response.StatusCode);
            Assert.AreEqual(AuthenticationMethod.SendCode, response.MfaType);
        }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        [TestProperty(_institution, PlaidSandbox.Institution.BankOfAmerica)]
        public async Task AuthenticateUserAsync_should_handle_a_multi_question_based_mfa_requirement()
        {
            // Arrange
            var handledAuthentication = false;
            var options = new ConnectOptions()
            {
                List = false,
                LoginOnly = true
            };
            var institutionType = TestContext.Properties[_institution].ToString();
            var credentials = new Credential(PlaidSandbox.StandardUser, PlaidSandbox.Password);
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret, Environment);

            // Act
            var response = await sut.AddUserAsync(credentials, institutionType, options);
            var questions = new Stack<string>(response.GetSecurityQuestions());
            while (questions.Count > 0)
            {
                questions.Pop();
                var answer = "tomato";
                response = await sut.AuthenticateUserAsync(credentials, response.AccessToken, answer);
                handledAuthentication = true;
            }

            // Assert
            Assert.IsTrue(handledAuthentication);
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        [TestProperty(_institution, PlaidSandbox.Institution.Chase)]
        public async Task AuthenticateUserAsync_should_handle_a_code_based_mfa_requirement()
        {
            // Arrange
            var handledAuthentication = false;
            var options = new ConnectOptions()
            {
                List = true,
                LoginOnly = true
            };
            var institutionType = TestContext.Properties[_institution].ToString();
            var credentials = new Credential(PlaidSandbox.StandardUser, PlaidSandbox.Password);
            var sut = new PlaidConnectClient(PlaidSandbox.ClientId, PlaidSandbox.Secret, Environment);

            // Act
            var response = await sut.AddUserAsync(credentials, institutionType, options);
            var authenticationMethod = response.GetAuthenticationMethods().First();

            if (authenticationMethod != null)
            {
                response = await sut.AuthenticateUserAsync(credentials, response.AccessToken, authenticationMethod, mfa: "1234");
                handledAuthentication = true;
            }

            // Assert
            Assert.IsTrue(handledAuthentication);
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        #region Private Members

        private const string _institution = "institution";

        #endregion Private Members
    }
}