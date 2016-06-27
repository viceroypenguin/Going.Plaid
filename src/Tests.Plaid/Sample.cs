using System;
using System.IO;
using System.Linq;

namespace Tests.Plaid
{
    public partial class Sample
    {
        public static FileInfo GetFile(string filename)
        {
            filename = Path.GetFileName(filename);
            string ext = "*" + Path.GetExtension(filename);
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            return new DirectoryInfo(baseDirectory).GetFiles(ext, SearchOption.AllDirectories)
                .First(x => x.Name == filename);
        }

        public static string GetFileContent(string filename)
        {
            return System.IO.File.ReadAllText(GetFile(filename).FullName);
        }

        public struct File
        {
            public const string CodeBaseMFA = "code-based mfa.json";
            public const string QuestionBasedMFA = "question-based mfa.json";
        }
    }
}