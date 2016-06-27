using Gigobyte.Plaid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace Tests.Plaid.IntegrationTests
{
    [TestClass]
    public class PlaidInstitutionClientTest
    {
        internal Gigobyte.Plaid.Environment Environment = Environment.Development;

        public TestContext TestContext { get; set; }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        public async Task RetrieveInstitutionAsync_should_retrieve_an_institution_object_when_a_id_is_given()
        {
            // Arrange
            var id = "5301a93ac140de84910000e0";
            var sut = new PlaidInstitutionClient(Environment);

            // Act
            var institution = await sut.RetrieveInstitutionAsync(id);

            // Assert
            Assert.AreEqual(id, institution.Id);
        }

        [TestMethod]
        [Owner(Dev.Ackara)]
        [TestCategory(Trait.Integration)]
        public async Task LookupInstitutionAsync_should_retrieve_a_list_of_institution_objects_when_search_term_is_given()
        {
            // Arrange
            var searchTerm = "scotia";
            var sut = new PlaidInstitutionClient(Environment);

            // Act
            var institutions = (await sut.LookupInstitutionAsync(searchTerm)).ToList();

            // Assert
            Assert.IsTrue(institutions.Count > 0);
            CollectionAssert.AllItemsAreNotNull(institutions);
        }
    }
}