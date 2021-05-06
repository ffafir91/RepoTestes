using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ProjetoPessoalTeste1.Page_Object
{
    public class Unidade
    {
        [FindsBy(How = How.XPath, Using = "//body[@id='contact']/div[@id='page']/div[@class='columns-container']/div[@id='columns']/div[3]/div[@id='center_column']/p[@class='alert alert-success']")]
        public IWebElement MensagemSucesso { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@role='dialog']/div[@class='cc-compliance']/a[@class='cc-btn cc-allow']")]
        public IWebElement buttonParaValidarCookie { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='client-doctor-headercomponentstyle__DesktopBottomHeaderStyled-owoxoj-2 ecHFDG']/div[1]/div[1]/div[1]/div[1]/div[@class='boxcomponentstyle__Item-sc-43ermp-1 hhcXYp']/a[@href='/unidades']")]
        public IWebElement buttonUnidades { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 efEBCe']/div[@class='sc-htpNat gridcomponent__ColStyled-sc-8zg10d-2 bmAjeB']/h1")]
        public IWebElement tituloUnidades { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[1]/div[@class='backgroundstyled__NeutralBackground-sc-1b1f5j3-3 dHyzS']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 eYPaKj']/div[1]/div[1]/a[@id='anchor-unit-cell-republica-do-libano-i']/div[1]/div[1]/div[1]/div[@class='boxcomponentstyle__Item-sc-43ermp-1 kVNSgu']/h3[@class='typographycomponentstyle__H3-sc-1oox73n-3 caOpMn']")]
        public IWebElement NomeUnidadeRepublicaLibano { get; set; }

        [FindsBy(How = How.Id, Using = "button-see-on-map-2-republica-do-libano-i")]
        public IWebElement buttonVerDetalhesUnidade { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".typographycomponentstyle__H1-sc-1oox73n-1")]
        public IWebElement tituloUnidadeSelecionada { get; set; }

        [FindsBy(How = How.Id, Using = "checkoox-select-facilities")]
        public IWebElement CheckBoxFacilidades { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 fqDNCQ']/div[3]/div[1]/div[@class='animationcomponentstyle__ForcedFade-sc-7lsrx1-1 ebkWHA']/div[1]/div[5]/label[@for='_Bicicletário e vaga verde']")]
        public IWebElement OpcaoFacilidadeBicicletario { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 fqDNCQ']/div[3]/div[1]/div[@class='animationcomponentstyle__ForcedFade-sc-7lsrx1-1 ebkWHA']/div[1]/div[6]/label[@for='_Atendimento aos domingos']")]
        public IWebElement OpcaoFacilidadeAtendimentoDomingo { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 fqDNCQ']/div[3]/div[1]/div[@class='animationcomponentstyle__ForcedFade-sc-7lsrx1-1 ebkWHA']/div[1]/div[7]/label[@for='_Vacinação']")]
        public IWebElement OpcaoFacilidadeVacinacao { get; set; }

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

        public void ClicarCheckBoxFacilidades()
        {
            CheckBoxFacilidades.Click();
        }

        public void ClicarOpcaoFacilidadeBicicletario()
        {
            OpcaoFacilidadeBicicletario.Click();
        }

        public void ClicarOpcaoFacilidadeAtendimentoDomingo()
        {
            OpcaoFacilidadeAtendimentoDomingo.Click();
        }

        public void ClicarOpcaoFacilidadeVacinacao()
        {
            OpcaoFacilidadeVacinacao.Click();
        }
    }
}
