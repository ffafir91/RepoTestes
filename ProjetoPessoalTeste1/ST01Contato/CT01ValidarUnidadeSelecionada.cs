using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoPessoalTeste1.Page_Object;
using ProjetoPessoalTeste1.PageObjects;
using ProjetoPessoalTeste1.Fixtures;

namespace ProjetoPessoalTeste1.ST01Contato
{
    [TestFixture]
    public class CT01ValidarUnidadeSelecionada: Fixture
    {
        [Test]
        public void ValidarUnidadeSelecionada()
        {
            #region Objects
            Contact contato = new Contact();
            string nomeUnidadeSelecionada;
            string tituloUnidadeSelecionada;
            #endregion

            #region Iniciar o acesso ao site e os elementos
            // Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            // Preenche todos os campos do formulário
            PageFactory.InitElements(driver, contato);
            #endregion

            #region Ações (comandos)
            //Ações a serem realizadas na tela para realizar o teste
            contato.ClicarBotaoUnidades();
            IWebElement nomeDaUnidade = wait.Until(e => e.FindElement(By.XPath("//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 efEBCe']/div[@class='sc-htpNat gridcomponent__ColStyled-sc-8zg10d-2 bmAjeB']/h1")));
            contato.ClicarBotaoContinuarCookie();
            contato.ClicarBotaoVerDetalhesUnidade();
            IWebElement tituloDaUnidadeSelecionada = wait.Until(f => f.FindElement(By.XPath("//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 efEBCe']/div[@class='sc-htpNat gridcomponent__ColStyled-sc-8zg10d-2 bmAjeB']/h1")));
            #endregion

            //Variável local que recebe o valor do elemento mapeado para realizar a validação
            nomeUnidadeSelecionada = nomeDaUnidade.Text;
            tituloUnidadeSelecionada = tituloDaUnidadeSelecionada.Text;

            #region Validação a ser realizada
            //Validar se o nome exibido no título é condizente com a unidade selecionada
            Assert.AreEqual(nomeUnidadeSelecionada, tituloUnidadeSelecionada);
            #endregion
        }
    }
}
