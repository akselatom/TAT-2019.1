namespace DEV_9.PageObjects.Mail
{
    using OpenQA.Selenium;

    public class MailHomePage
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver driver;

        public MailHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}