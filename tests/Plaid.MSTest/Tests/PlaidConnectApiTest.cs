using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Acklann.Plaid.Connect;
using ApprovalTests;
using System.Threading.Tasks;
using ApprovalTests.Reporters;

namespace Acklann.Plaid.MSTest.Tests
{
    [TestClass]
    [UseReporter(typeof(FileLauncherReporter))]
    public class PlaidConnectApiTest
    {
        [TestMethod]
        public void AddUser_should_return_a_success_response_when_valid_args_are_passed()
        {
            // Arrange
            var sut = new PlaidConnectClient(development: true);

            // Act
            var response = sut.AddUser(TestRequest.CreateConnectRequest());

            // Assert
            response.AccessToken.ShouldNotBeNullOrEmpty();
            response.Accounts.Length.ShouldBeGreaterThanOrEqualTo(1);
            response.Transactions.Length.ShouldBeGreaterThanOrEqualTo(1);
        }


    }
}
