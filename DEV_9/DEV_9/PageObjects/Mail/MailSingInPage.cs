namespace DEV_9.PageObjects.Mail
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class MailSingInPage
    {
        /// <summary>
        /// The login input locator.
        /// </summary>
        private By loginInputLocator = By.XPath("//input[@name = 'login']");

        /// <summary>
        /// The password input locator.
        /// </summary>
        private By passwordInputLocator = By.XPath("//input[@type = 'password']");

        /// <summary>
        /// The submit button locator.
        /// </summary>
        private By submitButtonLocator = By.XPath("//label/child::input[@type = 'submit']");

        /// <summary>
        /// The save login button locator.
        /// </summary>
        private By saveLoginButtonLocator = By.XPath("//label/child::input[@type = 'checkbox']");

        /// <summary>
        /// Initializes a new instance of the <see cref="MailSingInPage"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        public MailSingInPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.LoginInputElement = this.InitiateIWebElement(this.loginInputLocator);
            this.PasswordInputElement = this.InitiateIWebElement(this.passwordInputLocator);
            this.SubmitButtonElement = this.InitiateIWebElement(this.submitButtonLocator);
        }

        /// <summary>
        /// Gets <see cref="IWebDriver"/>
        /// </summary>
        public IWebDriver Driver { get; private set; }

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
        /// The type login in input field.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <returns>
        /// The <see cref="MailSingInPage"/>.
        /// </returns>
        public MailSingInPage TypeLogin(string login)
        {
            this.LoginInputElement.SendKeys(login);
            return this;
        }

        /// <summary>
        /// The type password. at password input field
        /// </summary>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// Returns the new instance of the <see cref="MailHomePage"/> class.
        /// </returns>
        public MailSingInPage TypePassword(string password)
        {
            this.PasswordInputElement.SendKeys(password);
            return this;
        }

        /// <summary>
        /// Click submit button.
        /// </summary>
        /// <returns>
        /// The <see cref="MailHomePage"/>.
        /// </returns>
        public MailHomePage ClickSubmitButton()
        {
            this.SubmitButtonElement.Click();
            return new MailHomePage(this.Driver);
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