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

        public By WriteANewLetterButton { get; private set; }

        public HomePage(IWebDriver driver)
        {
            this.WriteANewLetterButton = By.XPath("//div[@role ='button' and contains(., 'Написать')] ");
            this.driver = driver;
        }
    }
}