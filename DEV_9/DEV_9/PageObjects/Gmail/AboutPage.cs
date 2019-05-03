namespace DEV_9.PageObjects.Gmail
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.Events;

    public class AboutPage
    {
        /// <summary>
        /// The login button locator.
        /// </summary>
        private By singInButtonLocator = By.XPath("//a[contains(., 'Войти')] | //a[contains(., 'Sign')]");

        private IWebDriver driver;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            if (!driver.Url.Contains("gmail/about/")) 
            {
                throw new ArgumentException("This is not the about page");
            }
        }

        public SingInPage SingIn()
        {
            this.driver.FindElement(this.singInButtonLocator).Click();
            return new SingInPage(this.driver);
        }
    }
}