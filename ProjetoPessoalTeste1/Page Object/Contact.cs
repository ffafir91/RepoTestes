using OpenQA.Selenium;
using ProjetoPessoalTeste1.Fixtures;
using OpenQA.Selenium.Support.PageObjects;

namespace ProjetoPessoalTeste1.Page_Object
{
    public class Contact: Fixture
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
