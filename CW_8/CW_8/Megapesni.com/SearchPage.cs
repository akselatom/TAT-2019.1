namespace CW_8.Megapesni.com
{
    using OpenQA.Selenium;

    /// <summary>
    /// The search page.
    /// </summary>
    public class SearchPage
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver driver; 

        /// <summary>
        /// The download button.
        /// </summary>
        public readonly By DownloadButtonLocator = By.XPath("(//a[contains(@class,'download')])[1]");

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPage"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// The initiate download button.
        /// </summary>
        /// <returns>
        /// The <see cref="IWebElement"/>.
        /// </returns>
        public IWebElement InitiateDownloadButton()
        {
            return this.driver.FindElement(this.DownloadButtonLocator).Enabled
                       ? this.driver.FindElement(this.DownloadButtonLocator)
                       : null;
        }

        /// <summary>
        /// The click download button.
        /// </summary>
        /// <returns>
        /// The <see cref="DownloadPage"/>.
        /// </returns>
        public DownloadPage GoToDownloadPage()
        {
            this.InitiateDownloadButton().Click();
            return new DownloadPage(this.driver);
        }
    }
}