namespace MailTests
{
    using System;

    using DEV_9.PageObjects.Gmail;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium;

    [TestClass]
    public class GmailLogInTests
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// The log in positive test.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        [DataRow("kalykhan.tat2019@gmail.com", "TAT-2019.1")]
        [DataTestMethod]
        public void LogInWithCorrectDataTest(string login, string password)
        {
            AboutPage aboutPage = new AboutPage(@"C:\SeleniumDriver");
            this.driver = aboutPage.Driver;
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            SingInPage singInPage = aboutPage.SingIn();
            singInPage.TypeLogin(login);
            singInPage.TypePassword(password);
            Assert.IsTrue(this.driver.FindElement(singInPage.ClickSubmitButton().WriteANewLetterButton).Displayed);
        }

        /// <summary>
        /// The log in with wrong login or password test.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        [DataRow("kalykhan.tat2019@gmail.com", "NotRightPassword")]
        [DataTestMethod]
        [ExpectedException(typeof(NoSuchElementException))]
        public void LogInWithWrongDataTest(string login, string password)
        {
            AboutPage aboutPage = new AboutPage(@"C:\SeleniumDriver");
            this.driver = aboutPage.Driver;
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            SingInPage singInPage = aboutPage.SingIn();
            singInPage.TypeLogin(login);
            singInPage.TypePassword(password);
            Assert.IsFalse(this.driver.FindElement(singInPage.ClickSubmitButton().WriteANewLetterButton).Displayed);
        }

        /// <summary>
        /// The enter empty login test.
        /// </summary>
        [TestMethod]
        public void EnterEmptyLoginTest()
        {
            AboutPage aboutPage = new AboutPage(@"C:\SeleniumDriver");
            this.driver = aboutPage.Driver;
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            SingInPage singInPage = aboutPage.SingIn();
            singInPage.TypeLogin(Keys.Enter);
            Assert.IsTrue(
                this.driver.FindElement(By.XPath("//div[contains(.,'Введите')] | //div[contains(.,'Enter')]"))
                    .Displayed);
        }

        /// <summary>
        /// The enter empty password test.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        [DataRow("kalykhan.tat2019@gmail.com", "")]
        [DataTestMethod]
        public void EnterEmptyPasswordTest(string login, string password)
        {
            AboutPage aboutPage = new AboutPage(@"C:\SeleniumDriver");
            this.driver = aboutPage.Driver;
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            SingInPage singInPage = aboutPage.SingIn();
            singInPage.TypeLogin(login);
            singInPage.TypePassword(Keys.Enter);
            Assert.IsTrue(
                this.driver.FindElement(By.XPath("//div[contains(.,'Введите')] | //div[contains(.,'Enter')]"))
                    .Displayed);
        }
    }
}