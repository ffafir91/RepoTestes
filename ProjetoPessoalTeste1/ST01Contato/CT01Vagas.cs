using Bogus;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoPessoalTeste1.Page_Object;
using ProjetoPessoalTeste1.PageObjects;
using ProjetoPessoalTeste1.Fixtures;
using ProjetoPessoalTeste1.WaitHelpers;

namespace ProjetoPessoalTeste1.ST01Contato
{
    public class CT01Vagas: Fixture
    {
        private Faker faker = new Faker("pt-BR");
        [Test]
        public void ValidarBuscadorDeVagas()
        {
            #region Objects
            Vagas vagas = new Vagas();
            #endregion

            #region Iniciar o acesso ao site e os elementos
            //Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            //Preenche os campos do formulário
            PageFactory.InitElements(driver, vagas);
            #endregion

            #region Ações/Comandos no processo do teste
            wait.Until(ExpectedConditionsActual.ElementExists(By.XPath("//body/div[@id='root']/div[1]/div[1]/div[1]/div[@class='sc-fYxtnH gOrYtD']")));
            vagas.campoBuscarVaga.Clear();
            vagas.campoBuscarVaga.SendKeys("Analista QA Sênior");
            vagas.campoBuscarVaga.SendKeys(Keys.Enter);
            #endregion

            #region Validações a serem realizadas
            Assert.AreEqual("Analista QA Sênior", vagas.vagaSelecioanda.Text);
            #endregion
        }

        [Test]
        public void ValidarCadastroBancoDeTalentos()
        {
            #region Objects
            Vagas vagas = new Vagas();
            var CPF = faker.Random.Number(11);
            var senha = faker.Random.AlphaNumeric(8);

            #endregion

            #region Iniciar o acesso ao site e os elementos
            //Acessa o site
            driver.Navigate().GoToUrl(baseURL + "?controller=contact");

            //Preenche os campos do formulário
            PageFactory.InitElements(driver, vagas);
            #endregion

            #region Ações/Comandos no processo de teste
            wait.Until(ExpectedConditionsActual.ElementExists(By.XPath("//body/div[@id='root']/div[1]/div[1]/div[1]/div[@class='sc-fYxtnH gOrYtD']")));
            vagas.ClicarEmCadastroBancoDeTalento();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.Name(vagas.campoEmailOuCpf.ToString())));
            vagas.ClicarEmRegistreSe();
            vagas.email.SendKeys(ConfigurationManager.AppSettings["email"]);
            vagas.cpf.SendKeys(CPF.ToString());
            vagas.senha.SendKeys(senha);
            vagas.repetirSenha.SendKeys(senha);
            vagas.SelecionarCheckboxLiConcordo();
            vagas.ClicarEmCadastrar();
            #endregion
        }
    }
}
