namespace DEV_9.PageObjects.Mail
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class SingInPage
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
            if (!driver.Url.Contains("mail.ru"))
            {
                throw new ArgumentException("This is not the sing in page");
            }
        }

        /// <summary>
        /// The type login in input field.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <returns>
        /// The <see cref="SingInPage"/>.
        /// </returns>
        public SingInPage TypeLogin(string login)
        {
            this.driver.FindElement(this.loginInputLocator).SendKeys(login);
            this.driver.FindElement(this.submitButtonLocator).Click();
            return this;
        }

        /// <summary>
        /// The type password. at password input field
        /// </summary>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// Returns the new instance of the <see cref="HomePage"/> class.
        /// </returns>
        public SingInPage TypePassword(string password)
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(3.0));
            wait.Until(ExpectedConditions.ElementIsClickable(this.passwordInputLocator));
            this.driver.FindElement(this.passwordInputLocator).SendKeys(password);
            return this;
        }

        /// <summary>
        /// Click submit button.
        /// </summary>
        /// <returns>
        /// The <see cref="HomePage"/>.
        /// </returns>
        public HomePage ClickSubmitButton()
        {
            this.driver.FindElement(this.submitButtonLocator).Click();
            return new HomePage(this.driver);
        }
    }
}