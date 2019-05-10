namespace DEV_9.PageObjects.Mail
{
    using OpenQA.Selenium;

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