namespace DEV_9.PageObjects.Gmail
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// The home page.
    /// </summary>
    public class GmailHomePage
    {
        /// <summary>
        /// Gets the write a new letter button.
        /// </summary>
        private By writeANewLetterButtonLocator = By.XPath("//div[@class ='aic']");

        /// <summary>
        /// Initializes a new instance of the <see cref="GmailHomePage"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        public GmailHomePage(IWebDriver driver)
        {
            this.Driver = driver;
            this.WriteANewLetterButton = this.InitiateIWebElement(this.writeANewLetterButtonLocator);
        }

        /// <summary>
        /// Gets write a new letter button.
        /// </summary>
        public IWebElement WriteANewLetterButton { get; private set; }

        /// <summary>
        /// Gets a driver.
        /// </summary>
        public IWebDriver Driver { get; private set; }

        /// <summary>
        /// The initiate <see cref="IWebElement"/>
        /// </summary>
        /// <param name="locator">
        /// The locator <see cref="By"/>.
        /// </param>
        /// <returns>
        /// The <see cref="IWebElement"/>.
        /// </returns>
        private IWebElement InitiateIWebElement(By locator)
        {
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(3.0));
            wait.Until(ExpectedConditions.ElementIsClickable(locator));
            return this.Driver.FindElement(locator);
        }
    }
}