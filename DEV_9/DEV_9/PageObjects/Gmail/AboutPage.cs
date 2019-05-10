namespace DEV_9.PageObjects.Gmail
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// The about page.
    /// </summary>
    public class AboutPage
    {
        /// <summary>
        /// The login button locator.
        /// </summary>
        private By singInButtonLocator = By.XPath("//a[contains(., 'Войти')] | //a[contains(., 'Sign')]");

        /// <summary>
        /// Gets a driver.
        /// </summary>
        public IWebDriver Driver { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutPage"/> class.
        /// </summary>
        /// <param name="chromeWebDriverPath">
        /// The chrome web driver path.
        /// </param>
        public AboutPage(string chromeWebDriverPath)
        {
            this.Driver = new ChromeDriver(chromeWebDriverPath);
            this.Driver.Navigate().GoToUrl("https://www.google.com/gmail/about/");
        }

        public AboutPage(IWebDriver driver)
        {
            this.Driver = driver;
            if (!driver.Url.Contains("gmail/about/")) 
            {
                throw new ArgumentException("This is not the about page");
            }
        }

        /// <summary>
        /// Click sing in button
        /// </summary>
        /// <returns>
        /// The <see cref="SingInPage"/>.
        /// </returns>
        public SingInPage SingIn()
        {
            
            this.Driver.Navigate().GoToUrl(this.Driver.FindElement(this.singInButtonLocator).GetAttribute("href"));
            return new SingInPage(this.Driver);
        }
    }
}