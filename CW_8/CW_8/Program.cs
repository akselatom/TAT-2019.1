
namespace CW_8
{
    /// <summary>
    /// The program.
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
            SongLoader songLoader = new SongLoader();
            songLoader.DownloadSong("prodigy");
        }
    }
}
