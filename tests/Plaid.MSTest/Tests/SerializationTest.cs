using ApprovalTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acklann.Plaid.MSTest.Tests
{
    [TestClass]
    public class SerializationTest
    {
        [TestMethod]
        public void TheConnectApiRequest_should_be_serializable_to_a_valid_json_object()
        {
            // Arrange
            var sut = TestRequest.CreateConnectRequest();

            // Act
            var json = sut.ToJson();

            // Assert
            Approvals.VerifyJson(json);
        }
    }
}