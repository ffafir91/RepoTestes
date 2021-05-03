using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoPessoalTeste1.WaitHelpers;
using ProjetoPessoalTeste1.Fixtures;

namespace ProjetoPessoalTeste1.Page_Object
{
    public class Contact
    {
        [FindsBy(How = How.XPath, Using = "//body[@id='contact']/div[@id='page']/div[@class='columns-container']/div[@id='columns']/div[3]/div[@id='center_column']/h1")]
        public IWebElement titulo { get; set; }

        [FindsBy(How = How.Id, Using = "id_contact")]
        public IWebElement tipoContato { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='id_contact']/option[@value='2']")]
        public IWebElement buttonContact { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "id_order")]
        public IWebElement order { get; set; }

        [FindsBy(How = How.Id, Using = "uniform-fileUpload")]
        public IWebElement carregarArquivo { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement message { get; set; }

        [FindsBy(How = How.Id, Using = "submitMessage")]
        public IWebElement send { get; set; }

        [FindsBy(How = How.XPath, Using = "//body[@id='contact']/div[@id='page']/div[@class='columns-container']/div[@id='columns']/div[3]/div[@id='center_column']/p[@class='alert alert-success']")]
        public IWebElement MensagemSucesso { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@role='dialog']/div[@class='cc-compliance']/a[@class='cc-btn cc-allow']")]
        public IWebElement buttonParaValidarCookie { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='client-doctor-headercomponentstyle__DesktopBottomHeaderStyled-owoxoj-2 FjEqa']/div[1]/div[1]/div[1]/div[1]/div[@class='boxcomponentstyle__Item-sc-43ermp-1 hhcXYp']/a[@href='/unidades']")]
        public IWebElement buttonUnidades { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 efEBCe']/div[@class='sc-htpNat gridcomponent__ColStyled-sc-8zg10d-2 bmAjeB']/h1")]
        public IWebElement tituloUnidades { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[@class='backgroundstyled__NeutralBackground-sc-1b1f5j3-3 dHyzS']/div[2]/div[2]/div[1]/div[1]/a[@id='anchor-unit-cell-campinas']/div[1]/div[1]/div[1]/div[3]/h3")]
        public IWebElement NomeUnidade { get; set; }

        [FindsBy(How = How.Id, Using = "button-see-on-map-2-campinas")]
        public IWebElement buttonVerDetalhesUnidade { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 efEBCe']/div[@class='sc-htpNat gridcomponent__ColStyled-sc-8zg10d-2 bmAjeB']/h1")]
        public IWebElement tituloUnidadeSelecionada { get; set; }

        public void ClicarBotaoContinuarCookie()
        {
            buttonParaValidarCookie.Click();
        }

        public void ClicarBotaoVerDetalhesUnidade()
        {
            buttonVerDetalhesUnidade.Click();
        }

        public void ClicarBotaoUnidades()
        {
            buttonUnidades.Click();
        }

        public void ClicarBotaoTipoContato()
        {
            buttonContact.Click();
        }

        public void ClicarBotaoSend()
        {
            send.Click();
        }
    }
}
