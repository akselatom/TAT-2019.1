using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_7
{
    class Program
    {
        static void Main(string[] args)
        {
            FtpWorker newFtpWorker = new FtpWorker("ftp://ftp.byfly.by/", "test/");
            Task[] downloadTask = new Task[newFtpWorker.GetFileNamesList().Count];
            int i = 0;
            foreach (var fileName in newFtpWorker.GetFileNamesList())
            {
                downloadTask[i] = new Task(() => newFtpWorker.DownloadFileFromFtpFolder(fileName));
                i++;
            }

            foreach (var task in downloadTask)
            {
                task.Start();
            }
            Task.WaitAll(downloadTask);
            Console.WriteLine("Job done");
        }
    }
}
