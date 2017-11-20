using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acklann.Plaid.MSTest
{
	[TestClass]
	public class ApprovalTestsCleaner
	{
		[AssemblyInitialize]
		public static void Cleanup(TestContext context) => ApprovalTests.Maintenance.ApprovalMaintenance.CleanUpAbandonedFiles();
	}

	public static class TestFile
	{
		public const string CONNECT_TEST_WELLS_RESPONSE = @"connect_test_wells_response.json";
	}

	public static class DataFile
	{
			}
}
