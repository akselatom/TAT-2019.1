namespace DEV_9.PageObjects.Gmail
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.Events;
    using OpenQA.Selenium.Support.UI;

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
        /// The driver.
        /// </summary>
        private IWebDriver driver;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
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
            
            this.driver.Navigate().GoToUrl(this.driver.FindElement(this.singInButtonLocator).GetAttribute("href"));
            return new SingInPage(this.driver);
        }
    }
}