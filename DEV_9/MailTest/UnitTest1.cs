﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailTest
{
    using DEV_9.PageObjects.Gmail;

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
            driver.Navigate().GoToUrl("https://accounts.google.com");
            SingInPage singInPage = new SingInPage(driver);
            singInPage.TypeLogin("kalykhan.tat2019@gmail.com");
            singInPage.TypePassword("TAT-2019.1");
        }
    }
}
