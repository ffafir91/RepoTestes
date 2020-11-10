using System;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoPessoalTeste1;
using ProjetoPessoalTeste1.Page_Object;

namespace ST01Contato
{
    [TestFixture]
    public class CT02ValidarCamposObrigatorios
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
        [Obsolete]
        public void TheCT02ValidarCamposObrigatoriosTest()
        {
            #region Objects
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, contato);
            #endregion

            // Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            // Acessa o menu Contato
            //driver.FindElement(By.CssSelector("em.fa.fa-bars")).Click();
            //driver.FindElement(By.CssSelector("div.sidr-inner > #nav-wrap > #primary_menu > #menu-item-80 > a > span")).Click();

            // Clica no botão Salvar sem preencher os campos obrigatórios
            contato.ClicarBotaoSend();

            // Valida as mensagens de erro por não preenchimento dos campos obrigatórios
            IWebElement mapeamentoMensagemErro = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//body[@id='contact']/div[@id='page']/div[@class='columns-container']/div[@id='columns']/div[3]/div[@id='center_column']/div[@class='alert alert-danger']/p")));
            string mensagemErro = mapeamentoMensagemErro.Text;
            Assert.AreEqual("There is 1 error", mensagemErro);
            Assert.AreEqual("Invalid email address.", driver.FindElement(By.XPath("//body[@id='contact']/div[@id='page']/div[@class='columns-container']/div[@id='columns']/div[3]/div[@id='center_column']/div[@class='alert alert-danger']/ol/li")).Text);
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
