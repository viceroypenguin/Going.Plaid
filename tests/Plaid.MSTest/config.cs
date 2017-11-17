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
			}

	public static class DataFile
	{
			}
}
