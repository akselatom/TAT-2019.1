namespace MailTests
{
    using System;

    using DEV_9;
    using DEV_9.PageObjects.Gmail;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// The gmail log in tests.
    /// </summary>
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
            GmailAboutPage aboutPage = null;
            try
            {
                aboutPage = new GmailAboutPage(AppDomain.CurrentDomain.BaseDirectory);
                var singInPage = aboutPage.GoToSingInPage();
                singInPage.InputLogin(login);
                singInPage.TypePassword(password);
                Assert.IsTrue(singInPage.GoToHomePage().WriteANewLetterButton.Enabled);
            }
            catch (WebDriverException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                aboutPage.Driver.Quit();;
            }
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
        public void LogInWithWrongDataTest(string login, string password)
        {
            GmailAboutPage aboutPage = null;
            try
            {
                aboutPage = new GmailAboutPage(AppDomain.CurrentDomain.BaseDirectory);
                var singInPage = aboutPage.GoToSingInPage();
                singInPage.InputLogin(login);
                singInPage.TypePassword(password);
                singInPage.PasswordInputElement.SendKeys(Keys.Enter);
                this.driver = singInPage.Driver;
                var wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(3.0));
                wait.Until(ExpectedConditions.ElementIsClickable(By.XPath("//div[contains(.,'Неверный')]")));
                Assert.IsTrue(this.driver.FindElement(
                    By.XPath("//div[contains(.,'Неверный')]")).Displayed);
            }
            catch (WebDriverException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                aboutPage.Driver.Quit(); ;
            }
        }

        /// <summary>
        /// The enter empty login test.
        /// </summary>
        [TestMethod]
        public void EnterEmptyLoginTest()
        {
            GmailAboutPage aboutPage = null;
            try
            {
                aboutPage = new GmailAboutPage(AppDomain.CurrentDomain.BaseDirectory);
                var singInPage = aboutPage.GoToSingInPage();
                singInPage.InputLogin(Keys.Enter);
                this.driver = singInPage.Driver;
                Assert.IsTrue(
                    this.driver.FindElement(By.XPath("//div[contains(.,'Введите')] | //div[contains(.,'Enter')]"))
                        .Enabled);
            }
            catch (WebDriverException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                aboutPage.Driver.Quit();
            }

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
            GmailAboutPage aboutPage = null;
            try
            {
                aboutPage = new GmailAboutPage(AppDomain.CurrentDomain.BaseDirectory);
                var singInPage = aboutPage.GoToSingInPage();
                singInPage.InputLogin(login);
                singInPage.TypePassword(Keys.Enter);
                this.driver = singInPage.Driver;
                Assert.IsTrue(
                    this.driver.FindElement(By.XPath("//div[contains(.,'Введите')] | //div[contains(.,'Enter')]"))
                        .Enabled);
            }
            catch (WebDriverException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                aboutPage.Driver.Quit();
            }

        }
    }
}