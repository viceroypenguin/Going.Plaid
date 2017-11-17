using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Plaid.MSTest")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Plaid.MSTest")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("b9c93cf7-88ff-45ff-850e-a8a20ff32e9e")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Approval Tests
[assembly: UseApprovalSubdirectory(nameof(ApprovalTests))]
[assembly: UseReporter(typeof(DiffReporter), typeof(ClipboardReporter))]