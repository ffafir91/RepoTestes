using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProjetoPessoalTeste1.Fixtures;
using PageFactory = ProjetoPessoalTeste1.PageObjects.PageFactory;

namespace ProjetoPessoalTeste1.Page_Object
{
    public class Produto : Fixture
    {
        /*public Produto()
        {
            PageFactory.InitElements<dynamic>(driver);
        }*/

        #region Elementos mapeados
        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement buttonAdicionarCarrinhoCompras { get; set; }

        #endregion

        #region Ações
        public void ClicarNoBotaoAdicionarAoCarrinho()
        {
            buttonAdicionarCarrinhoCompras.Click();
        }
        #endregion
    }
}
