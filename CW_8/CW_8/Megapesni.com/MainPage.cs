namespace CW_8.Megapesni.com
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// The main page.
    /// </summary>
    public class MainPage
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// Gets the search field locator
        /// </summary>
        public readonly By SearchFieldLocator = By.XPath("//input[contains(@class,'search')]");

        /// <summary>
        /// Gets the submit button locator.
        /// </summary>
        public readonly By SubmitButtonLocator = By.XPath("//button[contains(@type,'submit')]");

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        /// <param name="chromeDriverPath">
        /// The chrome Driver Path.
        /// </param>
        public MainPage(string chromeDriverPath)
        {
            try
            {
                this.driver = new ChromeDriver(chromeDriverPath);
            }
            catch (Exception)
            {
                Console.WriteLine("There is no selenium chrome driver in program directory");
                throw;
            }

            this.driver.Navigate().GoToUrl("https://megapesni.com/");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// The initiate download button.
        /// </summary>
        /// <returns>
        /// The <see cref="IWebElement"/>.
        /// </returns>
        public IWebElement InitiateSearchField()
        {
            return this.driver.FindElement(this.SearchFieldLocator).Enabled
                       ? this.driver.FindElement(this.SearchFieldLocator)
                       : null;
        }

        /// <summary>
        /// The initiate download button.
        /// </summary>
        /// <returns>
        /// The <see cref="IWebElement"/>.
        /// </returns>
        public IWebElement InitiateSubmitButton()
        {
            return this.driver.FindElement(this.SubmitButtonLocator).Enabled
                       ? this.driver.FindElement(this.SubmitButtonLocator)
                       : null;
        }

        /// <summary>
        /// The enter text in search field.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        /// <returns>
        /// The <see cref="MainPage"/>.
        /// </returns>
        public MainPage EnterTextInSearchField(string text)
        {
            this.InitiateSearchField().SendKeys(text);
            return this;
        }

        /// <summary>
        /// The submit search.
        /// </summary>
        /// <returns>
        /// The <see cref="SearchPage"/>.
        /// </returns>
        public SearchPage SubmitSearch()
        {
            this.InitiateSubmitButton().Click();
            return new SearchPage(this.driver);
        }
    }
}