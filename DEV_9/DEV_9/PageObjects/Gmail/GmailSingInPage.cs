
namespace DEV_9.PageObjects.Gmail
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class GmailSingInPage
    {
        /// <summary>
        /// The login input locator.
        /// </summary>
        private By loginInputLocator = By.XPath("//input[@type = 'email']");

        /// <summary>
        /// The password input locator.
        /// </summary>
        private By passwordInputLocator = By.XPath("//input[@type = 'password']");

        /// <summary>
        /// The submit button locator.
        /// </summary>
        private By submitButtonLocator = By.XPath("//div[contains(@id, 'Next')]");

        /// <summary>
        /// Initializes a new instance of the <see cref="GmailSingInPage"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        /// <exception cref="ArgumentException">
        /// if current page is not a sing in page throw <see cref="ArgumentException"/>
        /// </exception>
        public GmailSingInPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.LoginInputElement = this.InitiateIWebElement(this.loginInputLocator);

            // Password input element would be enable after login input
            this.SubmitButtonElement = this.InitiateIWebElement(this.submitButtonLocator);
        }

        /// <summary>
        /// Gets login input element.
        /// </summary>
        public IWebElement LoginInputElement { get; private set; }

        /// <summary>
        /// Gets password input element.
        /// </summary>
        public IWebElement PasswordInputElement { get; private set; }

        /// <summary>
        /// Gets submit button element.
        /// </summary>
        public IWebElement SubmitButtonElement { get; private set; }

        /// <summary>
        /// Gets a driver.
        /// </summary>
        public IWebDriver Driver { get; private set; }

        /// <summary>
        /// Type login at login input field and confirm it.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <returns>
        /// Updated <see cref="GmailSingInPage"/>.
        /// </returns>
        public GmailSingInPage InputLogin(string login)
        {
            this.LoginInputElement.SendKeys(login);
            this.SubmitButtonElement.Click();
            return this;
        }

        /// <summary>
        /// The type password at password input field
        /// </summary>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// Returns the new instance of the <see cref="GmailHomePage"/> class.
        /// </returns>
        public GmailSingInPage TypePassword(string password)
        {
            this.PasswordInputElement = this.InitiateIWebElement(this.passwordInputLocator);
            this.PasswordInputElement.SendKeys(password);
            return this;
        }

        /// <summary>
        /// The click submit button.
        /// </summary>
        /// <returns>
        /// The <see cref="GmailHomePage"/>.
        /// </returns>
        public GmailHomePage GoToHomePage()
        {
            if (!this.PasswordInputElement.Displayed)
            {
                throw new WebDriverArgumentException(
                    "Attempt to go to the login page without entering a login or password");
            }

            this.SubmitButtonElement = this.InitiateIWebElement(this.submitButtonLocator);
            this.SubmitButtonElement.Click();
            return new GmailHomePage(this.Driver);
        }

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