namespace DEV_9.PageObjects.Gmail
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

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

        /// <summary>
        /// The submit button locator.
        /// </summary>
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
        /// if current page is not a sing in page throw <see cref="ArgumentException"/>
        /// </exception>
        public SingInPage(IWebDriver driver)
        {
            this.driver = driver;
            if (!driver.Url.Contains("/signin"))
            {
                throw new ArgumentException("This is not the sing in page");
            }
        }

        /// <summary>
        /// Type login at login input field.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <returns>
        /// Updated <see cref="SingInPage"/>.
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
        public HomePage TypePassword(string password)
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(3.0));
            wait.Until(ExpectedConditions.ElementIsClickable(this.passwordInputLocator));
            this.driver.FindElement(this.passwordInputLocator).SendKeys(password);
            this.driver.FindElement(this.submitButtonLocator).Click();
            return new HomePage(this.driver);
        }
    }
}