# encoding: UTF-8
# language: pt

Feature: Produto no carrinho
    Como um cliente do site de e-commerce Amazon
    quero poder pesquisar produto
    e adiciona-lo no carrinho de compras

Background:
    Given o cliente esteja na página do e-commerce https://www.amazon.com.br/

@Positivo
Scenario: Adicionar um produto ao carrinho de compras
    And possua um cadastro no site de compras
    When pesquisar um <produto> através do campo de pesquisa
    And adiciona-lo ao carrinho de compras
    Then o sistema deve retornar uma mensagem de sucesso para a ação tomada
    And disponibilizar a tela de carrinho para poder visualizar o <produto> escolhido.
    Examples:
        |produto|
        |Mop Lava e Seca, MOP7740, Flash Limp|

@Negativo
Scenario: Pesquisar um produto inexistente
    And possua um cadastro no site de compras
    When informar um <produto> inexistente no campo de pesquisa
    And clicar no ícone de pesquisar
    Then deverá ser retornado uma mensagem de <produto> inexistente
    Examples:
        |produto|
        |!@#!@#!@#!@#|