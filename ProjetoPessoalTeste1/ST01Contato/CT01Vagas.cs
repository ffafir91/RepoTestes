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
        private readonly Faker faker = new Faker("pt_BR");

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

        /// Cenário de teste incompleto, devido erros de mapeamento de alguns elementos
        public void ValidarCadastroBancoDeTalentos()
        {
            #region Objects
            Vagas vagas = new Vagas();
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
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.Name("user")));
            vagas.ClicarEmRegistreSe();
            vagas.ClicarNoCampoEmail();
            vagas.email.SendKeys(ConfigurationManager.AppSettings["email"]);
            vagas.email.SendKeys(Keys.Tab);
            vagas.cpf.SendKeys("289.204.570-34");
            vagas.cpf.SendKeys(Keys.Tab);
            vagas.senha.SendKeys(senha);
            vagas.senha.SendKeys(Keys.Tab);
            vagas.repetirSenha.SendKeys(senha);
            vagas.SelecionarCheckboxLiConcordo();
            vagas.ClicarEmCadastrar();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.Id("tip00")));
            vagas.telefoneQuestionario.SendKeys(faker.Phone.PhoneNumberFormat());
            vagas.emailQuestionario.SendKeys(ConfigurationManager.AppSettings["email"]);
            vagas.confirmacaoEmailQuestionario.SendKeys(ConfigurationManager.AppSettings["email"]);
            vagas.nomeCompletoQuestionario.SendKeys(faker.Name.FindName());
            vagas.ClicarNoComboboxGenero();
            vagas.SelecionarGeneroMasculino();
            vagas.dataNascimentoQuestionario.SendKeys(faker.Date.Past().ToString("yyyy-MM-dd"));
            vagas.sobreVoceQuestionario.SendKeys(faker.Lorem.Word());
            vagas.ClicarEmSalvarDadosIrProximaEtapa();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body/div[@id='root']/div[1]/div[@class='sc-eAKXzc fiGVV']/div[1]/div[1]/div[1]/div[1]/div[@class='sc-ibxdXY gXtAig']/div[2]/p[@class='sc-iQKALj fqwBgv']")));
            vagas.ClicarOpcao1Ativo();
            vagas.Clicaropcao1BomCompanheiro();
            vagas.Clicaropcao1Conservador();
            vagas.Clicaropcao1Dedicado();
            vagas.Clicaropcao1Modesto();
            vagas.Clicaropcao1Persistente();
            vagas.ClicarEmSalvarDadosProximaEtapa();
            wait.Until(ExpectedConditionsActual.ElementIsVisible(By.XPath("//body/div[@id='root']/div[1]/div[@class='sc-eAKXzc fiGVV']/div[1]/div[1]/div[@class='sc-cjHlYL rawWj']/div[2]")));
            vagas.Clicaropcao2Contagiante();
            vagas.Clicaropcao2Exigente();
            vagas.Clicaropcao2Independente();
            vagas.Clicaropcao2Paciente();
            vagas.Clicaropcao2Sincero();
            vagas.Clicaropcao2Tranquilo();
            vagas.ClicarEmSalvarDadosFinalizar();

            #endregion

            #region Validações a serem realizadas 
            Assert.AreEqual(vagas.validarEmailCadastrado.ToString(), ConfigurationManager.AppSettings["email"]);
            #endregion
        }
    }
}
