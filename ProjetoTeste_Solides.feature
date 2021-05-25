# encoding: UTF-8
# language: pt

Feature: Vaga
    Como um usuário do sistema solides
    quero poder escolher e selecionar as vagas divulgadas

Background:
    Given o usuário esteja na página https://jobs.solides.com/nayaracorporation

@Positivo
Scenario:Pesquisar Vaga
    And haja vagas liberada para candidatura
    When ele clicar no campo de pesquisa
    And preencher a informação referente a uma <vaga> em aberto
    Then o sistema deve retornar na tela a <vaga> pesquisada
    Examples:
        | vaga |
        | <Analista QA Sênior> |
    
@Positivo
Scenario:Cadastrar Banco de Talentos
    When clicar no botão "Cadastre-se em nosso banco de talentos"
    And preencher todos os campos obrigatórios
    Then deverá aparecer que o usuário foi criado com sucesso no sistema.