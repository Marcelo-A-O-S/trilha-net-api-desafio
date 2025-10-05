# Gerenciador de Tarefas - API .NET + Entity Framework

Este projeto foi desenvolvido como parte do **Desafio de Projeto da DIO** na trilha .NET.  
O objetivo era implementar uma **API para gerenciamento de tarefas** com CRUD completo.

## 🚀 Tecnologias
- ASP.NET Core Web API
- Entity Framework Core
- Swagger para documentação
- MySql (com Migrations)

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
