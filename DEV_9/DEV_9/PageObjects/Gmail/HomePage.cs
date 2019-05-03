namespace DEV_9.PageObjects.Gmail
{
    using OpenQA.Selenium;

    /// <summary>
    /// The home page.
    /// </summary>
    public class HomePage
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}