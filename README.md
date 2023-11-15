# Base-Relacional-Nuvem
Este é um projeto C# que utiliza o Entity Framework Core para interagir com um banco de dados MySQL. O projeto inclui uma interface de console simples para inserir cursos e estudantes no banco de dados.

## Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado em sua máquina:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [MySQL Server](https://dev.mysql.com/downloads/)

## Configuração do Banco de Dados

1. Crie um banco de dados MySQL chamado `escola`.
2. Atualize a string de conexão no arquivo `dbContext.cs` com suas credenciais MySQL.

```csharp
optionsBuilder.UseMySql("Server=seuServidor;Database=escola;User Id=seuUsuario;Password=suaSenha;");
