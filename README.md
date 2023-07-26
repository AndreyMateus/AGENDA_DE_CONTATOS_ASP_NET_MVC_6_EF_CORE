# Agenda de Contatos em ASP.NET 6

Este é um projeto de uma Agenda de Contatos desenvolvido em ASP.NET 6, utilizando o padrão de arquitetura MVC e o Entity Framework Core,
o projeto de Agenda de Contatos permite que o usuário crie, edite e exclua contatos. Os dados são armazenados em um banco de dados SQL Server.

## Pré-requistos para Rodar o Projeto 
**<p>.NET RUN TIME - 6.0</p>**
**<p>SQL SERVER</p>**

## Como baixar e rodar o projeto
1. Execute um git clone ou baixa o projeto
2. Abra o arquivo `appsettings.json` e edite a string de conexão com o banco de dados de acordo com sua configuração.

**OBS: Não precisa ter o database e as tabelas criadas, o próprio ef core irá criar para você, você só precisa passar o nome de qualquer DATABASE na connection string, MESMO QUE ELE NÃO EXISTA, O EF CORE IRÁ CRIAR ELE PARA VOCÊ, ELE SÓ PRECISA QUE VOCÊ DÊ UM NOME AO DATABASE, E VOCÊ FAZ ISSO PASSANDO O NOME QUE VOCÊ QUER NA CONNECTION STRING, Exemplo: `database=nomedodatabase`**

3. Vá dentro do projeto via CLI/Terminal
4. No terminal, execute o seguinte comando para criar o banco de dados: `dotnet ef database update`
5. Execute um `dotnet restore`
6. Execute um `dotnet build`
7. Execute um `dotnet run`

## Como Utilizar
Para utilizar o projeto, siga os seguintes passos:

1. Clone o repositório do Github para sua máquina.
2. Abra o projeto em seu editor de código preferido.
3. No terminal, execute o seguinte comando para baixar as dependências necessárias: `dotnet restore`
4. Siga as instruções acima para configurar o banco de dados.
5. Execute o projeto com o comando `dotnet run`.

[Link: Vídeo Demonstração](https://www.youtube.com/watch?v=CQki26OdHHU)
