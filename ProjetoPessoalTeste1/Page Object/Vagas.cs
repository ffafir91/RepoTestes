using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ProjetoPessoalTeste1.Page_Object
{
    public class Vagas
    {
        #region Mapeamento dos elementos para o processo de pesquisar vaga
        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[1]/div[1]/div[1]/div[@class='sc-tilXH fgVPoR']")]
        public IWebElement LogoSite { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[1]/div[1]/div[@class='sc-hEsumM fZcnWF']/div[1]/div[@type='search']/input[@type='search']")]
        public IWebElement campoBuscarVaga { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[1]/div[1]/div[@class='sc-hEsumM fZcnWF']/div[1]/div[@type='search']/div[@class='sc-kGXeez bObceN']")]
        public IWebElement buttonPesquisar { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[@class='sc-iELTvK kPkmMK']/div[@class='sc-cmTdod cyKJwc']/div[1]/div[@id='vacancyDescription']/div[1]/div[@class='sc-gxMtzJ gIvvhc']/div[1]/div[1]/div[1]/a[@href='#vacancyDescription']/div[@class='sc-jKVCRD kVbWmX']")]
        public IWebElement vagaSelecioanda { get; set; }

        #endregion

        #region Mapeamento dos elementos para criar um conta
        [FindsBy(How = How.Id, Using = "registerTalentBank")]
        public IWebElement buttonCadastroBancoDeTalentos { get; set; }

        [FindsBy(How = How.Name, Using = "user")]
        public IWebElement campoEmailOuCpf { get; set; }

        [FindsBy(How = How.Id, Using = "register")]
        public IWebElement buttonRegistreSe { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "cpf")]
        public IWebElement cpf { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement senha { get; set; }

        [FindsBy(How = How.Name, Using = "confirmPassword")]
        public IWebElement repetirSenha { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[@class='sc-csSMhA epWgGQ']/div[@class='sc-hlELIx gBfGmm']/div[2]/div[1]/form[@action='#']/div[5]/div[1]/div[1]/div[1]/div[1]/label[@class='pure-material-checkbox']")]
        public IWebElement checkboxLiConcordo { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[@class='sc-csSMhA epWgGQ']/div[@class='sc-hlELIx gBfGmm']/div[2]/div[1]/form[@action='#']/div[6]/button[@class='sc-jWBwVP kLcGOj']/div[@class='sc-brqgnP fuGZQg']")]
        public IWebElement buttonCadastrar { get; set; }

        [FindsBy(How = How.Id, Using = "tip00")]
        public IWebElement questionario { get; set; }

        [FindsBy(How = How.Id, Using = "contacts")]
        public IWebElement telefoneQuestionario { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement emailQuestionario { get; set; }

        [FindsBy(How = How.Id, Using = "secondEmail")]
        public IWebElement confirmacaoEmailQuestionario { get; set; }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement nomeCompletoQuestionario { get; set; }

        [FindsBy(How = How.Id, Using = "gender")]
        public IWebElement generoQuestionario { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[@id='container_pdf']/div[1]/div[1]/div[1]/div[@id='tip03']/div[@class='sc-lnmtFM hNYkoa']/div[1]/div[@class='sc-iuDHTM klGvdV']/div[1]/div[1]/div[@class='sc-VJcYb fvGyRD']/div[1]/div[@class='sc-cqCuEk iasZqf']")]
        public IWebElement generoFemininoQuestionario { get; set; }

        [FindsBy(How = How.Id, Using = "birthday")]
        public IWebElement dataNascimentoQuestionario { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[@id='container_pdf']/div[1]/div[@class='sc-ciodno dtaOEt']/div[1]/div[@class='sc-eEieub jmoXLN']/div[1]/button[@type='button']/div[@class='sc-brqgnP fYzsjR curriculum']")]
        public IWebElement buttonSalvarDadosAplicar { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[@class='sc-eAKXzc fiGVV']/div[1]/div[1]/div[1]/div[1]/div[@class='sc-ibxdXY gXtAig']/div[2]/p[@class='sc-iQKALj fqwBgv']")]
        public IWebElement textQuestionarioComportamental { get; set; }

        [FindsBy(How = How.Id, Using = "Persistente_1")]
        public IWebElement opcao1Persistente { get; set; }

        [FindsBy(How = How.Id, Using = "Ativo_1")]
        public IWebElement opcao1Ativo { get; set; }

        [FindsBy(How = How.Id, Using = "Modesto_1")]
        public IWebElement opcao1Modesto { get; set; }

        [FindsBy(How = How.Id, Using = "Bom Companheiro_1")]
        public IWebElement opcao1BomCompanheiro { get; set; }

        [FindsBy(How = How.Id, Using = "Conservador_1")]
        public IWebElement opcao1Conservador { get; set; }

        [FindsBy(How = How.Id, Using = "Dedicado_1")]
        public IWebElement opcao1Dedicado { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[@class='sc-eAKXzc fiGVV']/div[1]/div[1]/div[@class='sc-cjHlYL rawWj']/div[2]")]
        public IWebElement validarTelaOpcoes2Questionario { get; set; }

        [FindsBy(How = How.Id, Using = "Tranquilo_2")]
        public IWebElement opcao2Tranquilo { get; set; }

        [FindsBy(How = How.Id, Using = "Paciente_2")]
        public IWebElement opcaoPaciente { get; set; }

        [FindsBy(How = How.Id, Using = "Independente_2")]
        public IWebElement opcao2Independente { get; set; }

        [FindsBy(How = How.Id, Using = "Sincero_2")]
        public IWebElement opcao2Sincero { get; set; }

        [FindsBy(How = How.Id, Using = "Contagiante_2")]
        public IWebElement opcao2Contagiante { get; set; }

        [FindsBy(How = How.Id, Using = "Exigente_2")]
        public IWebElement opcao2Exigente { get; set; }

        [FindsBy(How = How.Id, Using = "saveDataToNextStep")]
        public IWebElement buttonSalvarDadosProximaEtapa { get; set; }

        [FindsBy(How = How.Id, Using = "saveFinalize")]
        public IWebElement buttonSalvarDadosFinalizar { get; set; }

        #endregion

        #region Ações a serem realizadas em Pesquisar Vagas
        public void ClicarEmPesquisar()
        {
            buttonPesquisar.Click();
        }
        #endregion

        #region Ações a serem realizadas em Realizar Cadastro
        public void ClicarEmCadastroBancoDeTalento()
        {
            buttonCadastroBancoDeTalentos.Click();
        }

        public void ClicarEmRegistreSe()
        {
            buttonRegistreSe.Click();
        }

        public void SelecionarCheckboxLiConcordo()
        {
            checkboxLiConcordo.Click();
        }

        public void ClicarEmCadastrar()
        {
            buttonCadastrar.Click();
        }

        public void ClicarEmSalvarDadosProximaEtapa()
        {
            buttonSalvarDadosProximaEtapa.Click();
        }

        public void ClicarEmSalvarDadosFinalizar()
        {
            buttonSalvarDadosFinalizar.Click();
        }
        #endregion

    }
}
