using System;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
//using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoPessoalTeste1;
using ProjetoPessoalTeste1.Page_Object;
using ProjetoPessoalTeste1.PageObjects;
using ProjetoPessoalTeste1.WaitHelpers;
using ProjetoPessoalTeste1.Fixtures;

namespace ST01Contato
{
    [TestFixture]
    public class CT03EnviarMensagem: Fixture
    {
        
        private bool acceptNextAlert = true;
        CT01ValidarLayoutTela ct01 = new CT01ValidarLayoutTela();
      
        [Test]
        public void TheCT03EnviarMensagemTest()
        {

            #region Objects
            Contact contato = new Contact();
            Fixture fixture = new Fixture();
            #endregion

            //ct01.SetupTest();
            ct01.TheCT01ValidarLayoutTelaTest();
            //ct01.TeardownTest();

            // Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            // Preenche todos os campos do formulário
            PageFactory.InitElements(driver, contato);
            
            contato.ClicarBotaoTipoContato();
            contato.email.Clear();
            contato.email.SendKeys(ConfigurationManager.AppSettings["email"]);
            contato.order.Clear();
            contato.order.SendKeys(ConfigurationManager.AppSettings["order"]);
            contato.message.Clear();
            contato.message.SendKeys(ConfigurationManager.AppSettings["message"]);


            // Clica no botão Enviar após preencher todos os campos obrigatórios
            contato.send.Click();

            // Valida a mensagem de sucesso do envio da mensagem.
            IWebElement selecionaMensagemSucesso = wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body[@id='contact']/div[@id='page']/div[@class='columns-container']/div[@id='columns']/div[3]/div[@id='center_column']/p[@class='alert alert-success']")));
            string mensagemSucesso = selecionaMensagemSucesso.Text;
            Assert.AreEqual("Your message has been successfully sent to our team.", mensagemSucesso);
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
