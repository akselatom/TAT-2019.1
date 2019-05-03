namespace DEV_9.PageObjects.Gmail
{
    using System;

    using OpenQA.Selenium;

    public class SingInPage
    {
        /// <summary>
        /// The login input locator.
        /// </summary>
        private By loginInputLocator = By.XPath("//input[@type = 'email']");

        /// <summary>
        /// The password input locator.
        /// </summary>
        private By passwordInputLocator = By.XPath("//input[@type = 'password']");

        private By submitButtonLocator = By.XPath("//div[contains(@id, 'Next')]");

        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingInPage"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public SingInPage(IWebDriver driver)
        {
            this.driver = driver;
            if (!driver.Title.Contains("Sing") || !driver.Title.Contains("Вход"))
            {
                throw new ArgumentException("This is not the sing in page");
            }
        }

        public SingInPage typeLogin(string login)
        {
            this.driver.FindElement(this.loginInputLocator).SendKeys(login);
            this.driver.FindElement(this.submitButtonLocator).Click();
            return this;
        }

        public HomePage typePassword(string password)
        {
            this.driver.FindElement(this.passwordInputLocator).SendKeys(password);
            this.driver.FindElement(this.submitButtonLocator).Click();
            return new HomePage(this.driver);
        }
    }
}