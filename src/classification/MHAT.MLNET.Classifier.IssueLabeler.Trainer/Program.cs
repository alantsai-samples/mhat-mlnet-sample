using System;
using System.IO;

namespace MHAT.MLNET.Classifier.IssueLabeler.Trainer
{
    class Program
    {
        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

        private static string DataPath => Path.Combine(AppPath, "Data", "corefx-issues-train.tsv");

        private static string TestPath => Path.Combine(AppPath, "Data", "corefx-issues-test.tsv");

        private static string ModelPath => Path.Combine(AppPath, "IssueLabelerModel.zip");

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
