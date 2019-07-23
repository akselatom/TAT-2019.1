
namespace CW_8
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// The program that download first song of any requested author from megapesni.com
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.C:\Users\Сергей\Documents\Visual Studio 2013\Projects\TAT-2019.1\CW_8\CW_8\Program.cs
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            try
            {
                SongLoader songLoader = new SongLoader();
                songLoader.DownloadSong("prodigy");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
