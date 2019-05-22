namespace CW_7
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// The program that download all files in ftp folder
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            FtpWorker newFtpWorker = new FtpWorker("ftp://ftp.byfly.by/", "test/");
            Task[] downloadTask = new Task[newFtpWorker.GetFileNamesList().Count];
            int i = 0;
            foreach (var fileName in newFtpWorker.GetFileNamesList())
            {
                downloadTask[i] = new Task(() => newFtpWorker.DownloadFileFromFtpFolder(fileName));
                i++;
            }

            // start download every file in ftp folder at the same time.
            foreach (var task in downloadTask)
            {
                task.Start();
            }

            Task.WaitAll(downloadTask);
            Console.WriteLine("Job done");
        }
    }
}
