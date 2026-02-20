# 🚀 TaskAuthApi - trilha-TIVIT-Api

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core-5C2D91?style=for-the-badge&logo=dotnet)
![Entity Framework](https://img.shields.io/badge/EF-Core-6C2DC7?style=for-the-badge)
![JWT](https://img.shields.io/badge/Auth-JWT-orange?style=for-the-badge&logo=jsonwebtokens)
![Swagger](https://img.shields.io/badge/Docs-Swagger-brightgreen?style=for-the-badge&logo=swagger)
![Docker](https://img.shields.io/badge/Docker-Containerized-2496ED?style=for-the-badge&logo=docker)
![Clean Architecture](https://img.shields.io/badge/Architecture-Clean-blue?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)



## 📌 Visão Geral

O **TaskAuthApi** é uma API RESTful desenvolvida com **.NET 8**, aplicando princípios de:

-  Arquitetura em camadas
-  Autenticação e autorização com JWT
-  Separação de responsabilidades (SRP)
-  Boas práticas de organização de código
-  Containerização com Docker
-  Documentação automática com Swagger

O projeto foi desenvolvido como parte da **trilha TIVIT**, com foco em consolidar fundamentos sólidos de backend moderno e seguro.



## 🏗️ Arquitetura

A aplicação segue uma estrutura organizada, inspirada em conceitos de Clean Architecture:
```C#
┣ 📂 Controllers → Endpoints HTTP
┣ 📂 DTOs → Objetos de transporte de dados
┣ 📂 Interfaces → Contratos (Inversão de Dependência)
┣ 📂 Services → Regras de negócio
┣ 📂 Mappers → Conversão entre entidades e DTOs
┣ 📂 Middlewares → Tratamento global de exceções
┣ 📂 Security → Configuração de JWT e autorização
┣ 📂 Data / Infra → Contexto e acesso a dados
┗ 📂 Migrations → Versionamento do banco
```

### 🔎 Princípios aplicados

- Inversão de Dependência
- Injeção de Dependência
- Responsabilidade Única
- Encapsulamento de regras de negócio
- Separação entre camada de API e domínio



## 🛠️ Stack Tecnológica

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (configurável)
- JWT Authentication
- Swagger / OpenAPI
- Docker
- EF Core Migrations


## 🔐 Segurança

A API utiliza:

- Autenticação baseada em **JWT**
- Controle de acesso via `[Authorize]`
- Middleware para tratamento global de exceções
- Configuração segura via `appsettings.json`



## 🔑 Funcionalidades

-  Cadastro de usuários
-  Login com geração de Token JWT
-  CRUD completo de tarefas
-  Proteção de rotas autenticadas
-  Documentação interativa com Swagger
-  Containerização com Docker



# 🐳 Execução com Docker Compose

O projeto está configurado para subir via Docker Compose, permitindo orquestração da API junto com o banco de dados.

**Subir os containers**
1. Clonar o repositório
```Bash
git clone https://github.com/Daniela2319/TaskAuthAPI-.git
cd TaskAuthAPI
```
2. No terminal:
```bash
docker-compose up --build
```
3. Acessar a aplicação
```Http
http://localhost:8080/swagger
```
## ▶️ Execução Local (sem Docker)
1. Clonar o repositório
```Bash
git clone https://github.com/Daniela2319/TaskAuthAPI-.git
cd TaskAuthAPI
```
2. Configurar conexão com banco
```Bash
appsettings.json
```
4. Executar migrations
```Bash
dotnet ef database update
```
4. Rodar aplicação
```Bash
dotnet run
```
Swagger:
```Http
https://localhost:5001/swagger
```
## 📖 Exemplos de Requisições
### 🔐 Login
```Bash
POST /api/auth/login
```
```Json
{
  "email": "usuario@exemplo.com",
  "password": "senha"
}
```
## 📝 Criar Tarefa (Autenticado)
```Bash
POST /api/tasks
Authorization: Bearer {token}
```
```Json
{
  "title": "Estudar .NET 8",
  "description": "Praticar desenvolvimento de APIs"  
}
```

## 🎯 Objetivo Profissional

Este projeto demonstra:

- Capacidade de estruturar APIs escaláveis

- Aplicação de padrões arquiteturais

- Conhecimento em segurança com JWT

- Organização modular

- Preparação para ambientes containerizados



## 👩🏻‍💻 Autora

Projeto desenvolvido por Daniela Velter
Foco em soluções digitais modernas e estratégicas.

[![LinkedIn](https://img.shields.io/badge/LinkedIn-%20DanielaVelter-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/danielavelteredu)





