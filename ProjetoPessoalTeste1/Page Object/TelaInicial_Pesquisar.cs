using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProjetoPessoalTeste1.Fixtures;
using PageFactory = ProjetoPessoalTeste1.PageObjects.PageFactory;

namespace ProjetoPessoalTeste1.Page_Object
{
    public class TelaInicial_Pesquisar: Fixture
    {
        /*public TelaInicial_Pesquisar()
        {
            PageFactory.InitElements<dynamic>(driver);
        }*/

        #region Mapeamento dos elementos para o processo de pesquisar vaga
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement campoPesquisar { get; set; }

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        public IWebElement iconePesquisar { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='a-page']/div[@id='search']/div[@class='s-desktop-width-max s-opposite-dir']/div[1]/div[1]/div[1]/span[@class='rush-component s-latency-cf-section']/div[2]/div[2]/div[1]/span[@class='celwidget slot=MAIN template=SEARCH_RESULTS widgetId=search-results']/div[1]/div[1]/div[2]/h2[@class='a-size-mini a-spacing-none a-color-base s-line-clamp-4']/a[@class='a-link-normal a-text-normal']/span[@class='a-size-base-plus a-color-base a-text-normal']")]
        public IWebElement resultadoPesquisa { get; set; }

        #endregion

        #region Ações
        public void SelecionarCampoPesquisar()
        {
            campoPesquisar.Click();
        }

        public void ClicarPesquisar()
        {
            iconePesquisar.Click();
        }

        public void ClicarResultadoPesquisa()
        {
            resultadoPesquisa.Click();
        }
        #endregion
    }
}
