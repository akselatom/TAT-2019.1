namespace CW_8
{
    using System;

    using CW_8.Megapesni.com;

    /// <summary>
    /// The song loader.
    /// </summary>
    public class SongLoader
    {
        /// <summary>
        /// The main page.
        /// </summary>
        private MainPage mainPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="SongLoader"/> class.
        /// </summary>
        public SongLoader()
        {
            this.mainPage = new MainPage(AppDomain.CurrentDomain.BaseDirectory);
        }

        /// <summary>
        /// The download song.
        /// </summary>
        /// <param name="songName">
        /// The song name.
        /// </param>
        public void DownloadSong(string songName)
        {
            this.mainPage.EnterTextInSearchField(songName);
            this.mainPage.SubmitSearch().GoToDownloadPage().DownloadButtonClick();
            
        }
    }
}