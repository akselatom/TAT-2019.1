namespace CW_7
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;

    public class FtpWorker
    {
        /// <summary>
        /// The ftp.
        /// </summary>
        private string ftp;

        /// <summary>
        /// The ftp folder.
        /// </summary>
        private string ftpFolder;

        /// <summary>
        /// Initializes a new instance of the <see cref="FtpWorker"/> class.
        /// </summary>
        /// <param name="ftp">
        /// The ftp.
        /// </param>
        /// <param name="ftpFolder">
        /// The ftp folder.
        /// </param>
        public FtpWorker(string ftp, string ftpFolder)
        {
            this.ftp = ftp;
            this.ftpFolder = ftpFolder;
        }

        public List<string> GetFileNamesList()
        {
            try  
            { 
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(this.ftp + this.ftpFolder);  
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();  
                Stream responseStream = response.GetResponseStream();  
                StreamReader reader = new StreamReader(responseStream);  
                string names = reader.ReadToEnd();  
      
                reader.Close();  
                response.Close();  
      
                return names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            catch (NullReferenceException ex)  
            {  
                Console.WriteLine(ex.Message);
                throw;
            }  
        }

        /// <summary>
        /// The download file from ftp folder.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <exception cref="Exception">
        /// throw exception when has trouble with ftp connect
        /// </exception>
        public void DownloadFileFromFtpFolder(string fileName)
        {
            try
            {
                Console.WriteLine("Download" + fileName);
                //Create FTP Request.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftp + ftpFolder + fileName);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
 
                //Enter FTP Server credentials.
                //request.Credentials = new NetworkCredential("Username", "Password");
                request.UsePassive = true;
                request.UseBinary = true;
                request.EnableSsl = false;
                
                //Fetch the Response and read it into a MemoryStream object.
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (Stream fileStream = new FileStream(@"d:\" + fileName, FileMode.CreateNew))
                    {
                        responseStream.CopyTo(fileStream);
                    }
                }
                Console.WriteLine("Downloaded" + fileName);
            }
            catch (WebException ex)
            {
                throw new Exception((ex.Response as FtpWebResponse).StatusDescription);
            }
        }
    }
}