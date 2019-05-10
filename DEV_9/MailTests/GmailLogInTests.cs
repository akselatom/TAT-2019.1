namespace MailTests
{
    using System;

    using DEV_9.PageObjects.Gmail;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium;

    [TestClass]
    public class GmailLogInTests
    {
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
        public void LogInPositiveTest(string login, string password)
        {
            AboutPage aboutPage = new AboutPage(@"C:\SeleniumDriver");
            this.driver = aboutPage.Driver;
            SingInPage singInPage = aboutPage.SingIn();
            singInPage.TypeLogin(login);
            singInPage.TypePassword(password);
        }
    }
}