namespace DEV_9.PageObjects.Gmail
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// The about page.
    /// </summary>
    public class GmailAboutPage
    {
        /// <summary>
        /// The login button locator.
        /// </summary>
        private By singInButtonLocator = By.XPath("//a[contains(., 'Войти')] | //a[contains(., 'Sign')]");

        /// <summary>
        /// Initializes a new instance of the <see cref="GmailAboutPage"/> class.
        /// </summary>
        /// <param name="chromeWebDriverPath">
        /// The chrome web driver path.
        /// </param>
        public GmailAboutPage(string chromeWebDriverPath)
        {
            this.Driver = new ChromeDriver(chromeWebDriverPath);
            this.Driver.Navigate().GoToUrl("https://www.google.com/gmail/about/");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GmailAboutPage"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        public GmailAboutPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        /// <summary>
        /// Gets login button element
        /// </summary>
        public IWebElement SingInButton { get; private set; }

        /// <summary>
        /// Gets a driver.
        /// </summary>
        public IWebDriver Driver { get; private set; }

        /// <summary>
        /// Navigate to sing in page
        /// </summary>
        /// <returns>
        /// The <see cref="GmailSingInPage"/>.
        /// </returns>
        public GmailSingInPage GoToSingInPage()
        {
            this.Driver.Navigate().GoToUrl(this.Driver.FindElement(this.singInButtonLocator).GetAttribute("href"));
            return new GmailSingInPage(this.Driver);
        }
    }
}