# SalesWebApp

SalesWebApp é uma aplicação ASP.NET Core MVC com Entity Framework Core voltada para o gerenciamento de vendedores, departamentos e registros de vendas. O projeto foi desenvolvido com foco em fins educacionais, demonstrando práticas como CRUD, injeção de dependência, programação assíncrona e o uso de migrações com EF Core.

## Tecnologias Utilizadas

- ASP.NET Core MVC (.NET 6 ou superior)
- Entity Framework Core
- SQL Server (LocalDB ou outro)
- Bootstrap
- C#

## Como Executar o Projeto

### **Pré-requisitos**

Antes de iniciar, você precisa ter os seguintes softwares instalados:

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)
- [Visual Studio 2022 ou superior](https://visualstudio.microsoft.com/)
- [SQL Server Express ou LocalDB](https://learn.microsoft.com/pt-br/sql/database-engine/configure-windows/sql-server-express-localdb)

### **Aplicar Migrações**

Após abrir o projeto no Visual Studio. Execute os seguintes comandos no Package Manager Console:

`Update-Database`

Esse comando irá aplicar as migrações e criar o banco de dados com as tabelas definidas.

### **Executar a Aplicação**

No Visual Studio, pressione `F5` ou clique em "Iniciar com Depuração".

A aplicação será iniciada e carregada automaticamente no navegador.
Por padrão, ela estará disponível em:

`https://localhost:7170`

Esse endereço pode variar dependendo da porta definida no arquivo `Properties/launchSettings.json`, dentro da propriedade `applicationUrl`.
