namespace CW_8.Megapesni.com
{
    using OpenQA.Selenium;

    /// <summary>
    /// The download page.
    /// </summary>
    public class DownloadPage
    {
        /// <summary>
        /// The download button locator.
        /// </summary>
        public readonly By DownloadButtonLocator =
            By.XPath("//a[contains(@class,'song')]/child::span[contains(@class,'download')]");

        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadPage"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        public DownloadPage(IWebDriver driver)
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
        /// The download button click.
        /// </summary>
        public void DownloadButtonClick()
        {
            this.InitiateDownloadButton().Click();
        }
    }
}