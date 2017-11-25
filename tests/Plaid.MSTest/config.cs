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
		public const string INSTITUTION_RESPONSE = @"institution_response.json";
		public const string TRANSACTIONS_FULL_RESPONSE = @"transactions_full_response.json";
		public const string TRANSACTIONS_SIMPLIFIED_RESPONSE = @"transactions_simplified_response.json";
	}

	public static class DataFile
	{
			}
}
