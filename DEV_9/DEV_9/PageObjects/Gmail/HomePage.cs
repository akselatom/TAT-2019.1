namespace DEV_9.PageObjects.Gmail
{
    using System;

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
            this.driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(2);
            if (!driver.Url.Contains("/mail/#inbox"))
            {
                throw new ArgumentException("This is not the sing in page");
            }
        }
    }
}