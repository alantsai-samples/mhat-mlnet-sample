using System;
using System.IO;
using System.Threading.Tasks;

namespace MHAT.MLNET.Classifier.IssueLabeler.Trainer
{
    class Program
    {
        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

        private static string DataPath => Path.Combine(AppPath, "Data", "corefx-issues-train.tsv");

        private static string TestPath => Path.Combine(AppPath, "Data", "corefx-issues-test.tsv");

        private static string ModelPath => Path.Combine(AppPath, "IssueLabelerModel.zip");

        static async Task Main(string[] args)
        {
            await TrainAsync();

            Console.ReadLine();
        }

        private static async Task TrainAsync()
        {
            throw new NotImplementedException();
        }
    }
}
