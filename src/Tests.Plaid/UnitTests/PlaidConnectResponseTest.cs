using Gigobyte.Plaid.Connect;
using Gigobyte.Plaid.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Linq;

namespace Tests.Plaid.UnitTests
{
    [TestClass]
    public class PlaidConnectResponseTest
    {
        [TestMethod]
        [Owner(Dev.Ackara)]
        public void GetSecurityQuestions_should_return_a_list_of_strings_when_the_object_requires_question_based_mfa()
        {
            // Arrange
            var json = Sample.GetFileContent(Sample.File.QuestionBasedMFA);
            var sut = JsonConvert.DeserializeObject<PlaidConnectResponse>(json);

            // Act
            var questions = sut.GetSecurityQuestions().ToList();

            // Assert
            Assert.IsTrue(questions.Count > 0);
            CollectionAssert.AllItemsAreNotNull(questions);
        }

        [TestMethod]
        [Owner(Dev.Ackara)]
        public void GetAuthenticationMethods_should_return_a_list_of_mfa_methods_when_the_object_requires_code_based_mfa()
        {
            // Arrange
            var json = Sample.GetFileContent(Sample.File.CodeBaseMFA);
            var sut = JsonConvert.DeserializeObject<PlaidConnectResponse>(json);

            // Act
            var methods = sut.GetAuthenticationMethods().ToList();

            // Assert
            Assert.IsTrue(methods.Count > 0);
            CollectionAssert.AllItemsAreNotNull(methods);
        }
    }
}