using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProjetoPessoalTeste1.PageObjects;
using ProjetoPessoalTeste1.Fixtures;
using PageFactory = ProjetoPessoalTeste1.PageObjects.PageFactory;

namespace ProjetoPessoalTeste1.Page_Object
{
    public class Carrinho: Fixture
    {
        /*public Carrinho()
        {
            PageFactory.InitElements<dynamic>(driver);
        }*/

        #region Elementos Mapeados
        [FindsBy(How = How.XPath, Using = "//body/div[@id='a-page']/div[@id='cart-page-wrap']/div[@id='huc-page-container']/div[@id='huc-v2-order-row-with-divider']/div[1]/div[1]/div[1]/div[@id='huc-v2-order-row-messages']/div[1]/div[1]/div[1]/div[1]/div[1]/h1")]
        public IWebElement mensagemProdutoAdicionadoCarrinho { get; set; }

        [FindsBy(How = How.Id, Using = "hlb-view-cart-announce")]
        public IWebElement buttonCarrinho { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='a-page']/div[@class='a-container sc-background-dark']/div[@id='content']/div[@id='sc-retail-cart-container']/div[1]/div[2]/div[1]/div[1]/form[@id='activeCartViewForm']/div[2]/div[3]/div[@class='sc-list-item-content']/div[1]/div[1]/div[1]/div[1]/div[2]/ul[@class='a-unordered-list a-nostyle a-vertical a-spacing-mini sc-info-block']/li/span[@class='a-list-item']/a[@class='a-link-normal sc-product-link']/span")]
        public IWebElement produtoAdicionadoAoCarrinho { get; set; }
        #endregion

        #region Ações
        public void ClicarBotaoCarrinho()
        {
            buttonCarrinho.Click();
        }
        #endregion
    }
}
