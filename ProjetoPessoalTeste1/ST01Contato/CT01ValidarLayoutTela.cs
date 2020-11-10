using System;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoPessoalTeste1.Page_Object;
using ProjetoPessoalTeste1.PageObjects;
using ProjetoPessoalTeste1;

namespace ST01Contato
{
    [TestFixture]
    public class CT01ValidarLayoutTela
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        Contact contato = new Contact();

        [SetUp]
        public void SetupTest()
        {
            driver = Comandos.GetBrowserLocal(driver, ConfigurationManager.AppSettings["browser"]);
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
        
        [Test]
        //[Obsolete]
        public void TheCT01ValidarLayoutTelaTest()
        {
            #region Objects
            PageFactory.InitElements(driver, contato);
            #endregion

            // Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            // Acessa o menu Contato
            //driver.FindElement(By.CssSelector("em.fa.fa-bars")).Click();
            //driver.FindElement(By.CssSelector("div.sidr-inner > #nav-wrap > #primary_menu > #menu-item-80 > a > span")).Click();
            
            // Valida o layout da tela
            Assert.AreEqual("CUSTOMER SERVICE - CONTACT US", contato.titulo.Text);
            Assert.IsTrue(contato.tipoContato.Enabled);
            Assert.IsTrue(contato.email.Enabled);
            Assert.IsTrue(contato.order.Enabled);
            Assert.IsTrue(contato.carregarArquivo.Enabled);
            Assert.IsTrue(contato.message.Enabled);
        }   
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
