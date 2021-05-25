using NUnit.Framework;
using ProjetoPessoalTeste1.WaitHelpers;
using ProjetoPessoalTeste1.Fixtures;
using ProjetoPessoalTeste1.Page_Object;
using ProjetoPessoalTeste1.PageObjects;
using OpenQA.Selenium;
using System.Configuration;

namespace ProjetoPessoalTeste1.ST01Contato
{
    public class ECommerce_Amazon: Fixture
    {
        [Test]
        public void InserirUmProdutoNoCarrinho()
        {
            #region Objects
            Carrinho carrinho = new Carrinho();
            Produto produto = new Produto();
            TelaInicial_Pesquisar pesquisar = new TelaInicial_Pesquisar();

            #endregion

            #region Iniciar o acesso ao site e os elementos
            //Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            //Preenche os campos do formulário
            PageFactory.InitElements(driver, pesquisar);
            PageFactory.InitElements(driver, produto);
            PageFactory.InitElements(driver, carrinho);
            #endregion

            #region Ações/Comandos para os testes
            //Tela Inicial
            pesquisar.SelecionarCampoPesquisar();
            pesquisar.campoPesquisar.SendKeys(ConfigurationManager.AppSettings["produto"]);
            pesquisar.ClicarPesquisar();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body/div[@id='a-page']/div[@id='search']/div[@class='s-desktop-width-max s-opposite-dir']/div[1]/div[1]/div[1]/span[@class='rush-component s-latency-cf-section']/div[2]/div[2]/div[1]/span[@class='celwidget slot=MAIN template=SEARCH_RESULTS widgetId=search-results']/div[1]/div[1]/div[2]/h2[@class='a-size-mini a-spacing-none a-color-base s-line-clamp-4']/a[@class='a-link-normal a-text-normal']/span[@class='a-size-base-plus a-color-base a-text-normal']")));
            
            //Resultado da pesquisa
            pesquisar.ClicarResultadoPesquisa();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.Id("add-to-cart-button")));
            
            //Produto selecionado e disponível para colocar no carrinho
            produto.ClicarNoBotaoAdicionarAoCarrinho();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body/div[@id='a-page']/div[@id='cart-page-wrap']/div[@id='huc-page-container']/div[@id='huc-v2-order-row-with-divider']/div[1]/div[1]/div[1]/div[@id='huc-v2-order-row-messages']/div[1]/div[1]/div[1]/div[1]/div[1]/h1")));
            
            //Carrinho contendo o produto adicionado
            carrinho.ClicarBotaoCarrinho();
            IWebElement mensagem = wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body/div[@id='a-page']/div[@class='a-container sc-background-dark']/div[@id='content']/div[@id='sc-retail-cart-container']/div[1]/div[2]/div[1]/div[1]/form[@id='activeCartViewForm']/div[2]/div[3]/div[@class='sc-list-item-content']/div[1]/div[1]/div[1]/div[1]/div[2]/ul[@class='a-unordered-list a-nostyle a-vertical a-spacing-mini sc-info-block']/li/span[@class='a-list-item']/a[@class='a-link-normal sc-product-link']/span")));

            #endregion

            #region Validações a serem realizadas
            Assert.AreEqual("Mop Lava e Seca, MOP7740, Flash Limp", mensagem.Text);

            #endregion

        }

        [Test]
        public void InformarValorIncorretoNaPesquisa()
        {
            #region Objects
            TelaInicial_Pesquisar pesquisar = new TelaInicial_Pesquisar();

            #endregion

            #region Iniciar o acesso ao site e os elementos
            //Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            //Preenche os campos do formulário
            PageFactory.InitElements(driver, pesquisar);

            #endregion

            #region Ações/Comandos para os testes
            //Tela Inicial
            pesquisar.SelecionarCampoPesquisar();
            pesquisar.campoPesquisar.SendKeys(ConfigurationManager.AppSettings["produtoIncorreto"]);
            pesquisar.ClicarPesquisar();
            IWebElement mensagemEnviada = wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body/div[@id='a-page']/div[@id='search']/div[@class='s-desktop-width-max s-opposite-dir']/div[1]/div[1]/div[1]/span[@class='rush-component s-latency-cf-section']/div[2]/div[1]/span[@class='celwidget slot=MAIN template=TOP_BANNER_MESSAGE widgetId=messaging-messages-no-results']/div[1]/div[1]/div[1]/span[2]")));

            #endregion

            #region Validações a serem realizadas
            Assert.AreEqual(ConfigurationManager.AppSettings["produtoIncorreto"], mensagemEnviada.Text);

            #endregion
        }
    }
}
