﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProjetoPessoalTeste1.Fixtures
{
    public class Fixture
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        public string baseURL;
        private StringBuilder verificationErrors;


        [SetUp]
        public void SetUp()
        {
            driver = Comandos.GetBrowserLocal(driver, ConfigurationManager.AppSettings["browser"]);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            baseURL = "http://automationpractice.com/index.php";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
    }
}
