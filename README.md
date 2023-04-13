# Readme - Agenda de Contatos em ASP.NET 6

Este é um projeto de uma Agenda de Contatos desenvolvido em ASP.NET 6, utilizando o padrão de arquitetura MVC e o Entity Framework Core.

## Instalação

Antes de executar o projeto, certifique-se de ter o Entity Framework Core instalado em sua máquina. Para isso, abra o terminal e execute o seguinte comando:

`dotnet tool install --global dotnet-ef`


Além disso, é necessário executar o comando `dotnet restore` na pasta raiz do projeto para baixar todas as dependências necessárias.

## Configuração do Banco de Dados

Este projeto utiliza o Entity Framework Core para se comunicar com o banco de dados. Para configurar o banco, siga os seguintes passos:

1. Abra o arquivo `appsettings.json` e edite a string de conexão com o banco de dados de acordo com sua configuração.

2. No terminal, execute o seguinte comando para criar o banco de dados: `dotnet ef database update`

3. Após isso, o banco de dados será criado e estará pronto para uso.


## Executando o Projeto
Para executar o projeto, abra o terminal e execute o seguinte comando na pasta raiz do projeto: `dotnet run`

## Funcionamento
O projeto de Agenda de Contatos permite que o usuário crie, edite e exclua contatos. Os dados são armazenados em um banco de dados SQL Server.


## Como Utilizar
Para utilizar o projeto, siga os seguintes passos:

1. Clone o repositório do Github para sua máquina.
2. Abra o projeto em seu editor de código preferido.
3. No terminal, execute o seguinte comando para baixar as dependências necessárias: `dotnet restore`
4. Siga as instruções acima para configurar o banco de dados.
5. Execute o projeto com o comando `dotnet run`.


## Agradecimentos
Agradeceço por utilizar o meu projeto de Agenda de Contatos em ASP.NET 6 e estou à disposição para eventuais dúvidas ou sugestões.


[Link: Vídeo Demonstração](https://www.youtube.com/watch?v=CQki26OdHHU)
