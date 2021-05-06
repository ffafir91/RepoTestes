using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoPessoalTeste1.Page_Object;
using ProjetoPessoalTeste1.PageObjects;
using ProjetoPessoalTeste1.Fixtures;
using ProjetoPessoalTeste1.WaitHelpers;

namespace ProjetoPessoalTeste1.ST01Contato
{
    [TestFixture]
    public class CT01ValidarUnidadeSelecionada: Fixture
    {
        [Test]
        public void ValidarUnidadeSelecionada()
        {
            #region Objects
            Unidade unidade = new Unidade();
            string nomeUnidadeSelecionada;
            string tituloUnidadeSelecionada;
            #endregion

            #region Iniciar o acesso ao site e os elementos
            // Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            // Preenche todos os campos do formulário
            PageFactory.InitElements(driver, unidade);

            #endregion

            #region Ações (comandos)
            //Ações a serem realizadas na tela para realizar o teste
            unidade.ClicarBotaoUnidades();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='backgroundstyled__NeutralBackground-sc-1b1f5j3-3 dHyzS']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 vfUcR']/div[@class='sc-htpNat gridcomponent__ColStyled-sc-8zg10d-2 dsZazA']/h2[@class='typographycomponentstyle__H2-sc-1oox73n-2 hYgaev']")));

            //Clicar no botão continuar presente na tela para evitar erros no mapeamento da tela
            unidade.ClicarBotaoContinuarCookie();

            //Comandos para selecionar facilidades
            unidade.ClicarCheckBoxFacilidades();
            wait.Until(ExpectedConditionsActual.ElementExists(By.XPath("//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 fqDNCQ']/div[3]/div[1]/div[@class='animationcomponentstyle__ForcedFade-sc-7lsrx1-1 ebkWHA']")));
            unidade.ClicarOpcaoFacilidadeBicicletario();
            unidade.ClicarOpcaoFacilidadeAtendimentoDomingo();
            unidade.ClicarOpcaoFacilidadeVacinacao();

            //Variável local que recebe o valor do elemento mapeado para realizar a validação
            nomeUnidadeSelecionada = unidade.NomeUnidadeRepublicaLibano.Text;

            //Selecionar a unidade
            unidade.ClicarBotaoVerDetalhesUnidade();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body/div[@id='___gatsby']/div[@id='gatsby-focus-wrapper']/div[@class='sc-bdVaJa gridcomponent__GridStyled-sc-8zg10d-0 fHFDYJ']/div[@class='sc-bwzfXH gridcomponent__RowStyled-sc-8zg10d-1 efEBCe']/div[@class='sc-htpNat gridcomponent__ColStyled-sc-8zg10d-2 bmAjeB']/h1[@class='typographycomponentstyle__H1-sc-1oox73n-1 lomAMa']")));

            //Variável local que recebe o valor do elemento mapeado para realizar a validação
            tituloUnidadeSelecionada = unidade.tituloUnidadeSelecionada.Text;
            #endregion

            #region Validação a ser realizada
            //Validar se o nome exibido no título é condizente com a unidade selecionada
            Assert.AreEqual(nomeUnidadeSelecionada, tituloUnidadeSelecionada);
            #endregion
        }
    }
}
