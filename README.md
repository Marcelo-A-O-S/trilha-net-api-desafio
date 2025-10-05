# Gerenciador de Tarefas - API .NET + Entity Framework

Este projeto foi desenvolvido como parte do **Desafio de Projeto da DIO** na trilha .NET.  
O objetivo era implementar uma **API para gerenciamento de tarefas** com CRUD completo.

## 🚀 Tecnologias
- ASP.NET Core Web API
- Entity Framework Core
- Swagger para documentação
- MySql (com Migrations)

## 🛠 Tecnologias e Bibliotecas Utilizadas

Aqui estão as principais bibliotecas e seus propósitos:

- **Microsoft.EntityFrameworkCore** 🗄️  
  Biblioteca principal do **Entity Framework Core**, utilizada para manipulação de dados via ORM.

- **Microsoft.EntityFrameworkCore.Design** 🛠️  
  Ferramentas para **design-time**, suporte a migrações e scaffolding.

- **Microsoft.EntityFrameworkCore.Tools** 🔧  
  Fornece **comandos CLI** para migrações e gerenciamento do banco de dados.

- **Pomelo.EntityFrameworkCore.MySql** 🐬  
  Provider **MySQL** para o Entity Framework Core, permitindo conexão e manipulação de banco MySQL.

- **Swashbuckle.AspNetCore** 📜  
  Gera **documentação automática da API** via Swagger, permitindo testes e visualização dos endpoints.

## ⚙️ Funcionalidades
- Cadastrar tarefa
- Atualizar tarefa
- Obter todas as tarefas
  - Titulo
  - Data
  - Status
- Obter tarefa por:
  - ID
  - Título
  - Data
  - Status
- Deletar tarefa

## 📂 Estrutura do Projeto
```
├───Api
│   ├───Context → Contexto do banco (EF Core)
│   ├───Controllers → Lógica de API
│   ├───DTOs → Objetos de Transferência de Dados (DTOs)
│   ├───Extensions → Pasta de organizações de configurações
│   │   └───Services → Configurações de Swagger, Contexto do EF e dentre outros
│   ├───Migrations → Histórico de alterações do banco
│   ├───Models → Modelos de dados
│   ├───Repositories → Lógica de persistência especifica e generica do projeto
│   │   └───Interfaces → Contratos de persistência especifica e generica do projeto
│   └───Services → Lógica de negócio do projeto
│       └───Interfaces → Contratos de negócio do projeto
└───docs → Conteudo do desafio original
```

## 📜 Desafio Original
O enunciado completo do desafio está disponível [aqui](./docs/README-DESAFIO.md).
