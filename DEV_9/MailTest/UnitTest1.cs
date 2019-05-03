using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailTest
{
    using DEV_9.PageObjects.Mail;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\SeleniumDriver");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3.0);
            driver.Navigate().GoToUrl("https://www.google.com/gmail/about/");
            DEV_9.PageObjects.Gmail.AboutPage aboutPage = new DEV_9.PageObjects.Gmail.AboutPage(driver);
            DEV_9.PageObjects.Gmail.SingInPage singInPage = aboutPage.SingIn();
            singInPage.TypeLogin("kalykhan.tat2019@gmail.com");
            singInPage.TypePassword("TAT-2019.1");
        }

        [TestMethod]
        public void TestMailRu()
        {
            IWebDriver driver = new ChromeDriver(@"C:\SeleniumDriver");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3.0);
            driver.Navigate().GoToUrl("https://mail.ru/");
            DEV_9.PageObjects.Mail.SingInPage singInPage = new SingInPage(driver);
            singInPage.TypeLogin("kalykhan.tat2019@mail.ru");
            singInPage.TypePassword("TAT-2019.1");
        }
    }
}
