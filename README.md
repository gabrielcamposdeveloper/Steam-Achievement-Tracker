# 🎮 Steam Achievement Tracker

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-orange)
![Backend](https://img.shields.io/badge/backend-.NET%209-purple)
![Frontend](https://img.shields.io/badge/frontend-Angular-red)
![Architecture](https://img.shields.io/badge/architecture-Hexagonal-blue)

Uma plataforma completa para análise, acompanhamento e evolução de **Achievements da Steam**, construída com foco em **arquitetura de software de nível sênior**, utilizando **Arquitetura Hexagonal (Ports & Adapters)**, **DDD**, **CQRS**, **Vertical Slice Architecture** e boas práticas modernas do ecossistema .NET.

O objetivo do projeto é transformar dados da Steam Web API em uma experiência rica de análise de progresso, estatísticas e gamificação.

---

# 🚀 Objetivos do Projeto

Este projeto tem como objetivos:

* Praticar arquitetura escalável utilizando C# e Angular.
* Aplicar princípios SOLID e Domain-Driven Design.
* Criar uma aplicação preparada para crescimento.
* Trabalhar integração com APIs externas.
* Construir uma aplicação próxima de cenários reais de mercado.
* Explorar padrões utilizados em sistemas corporativos.

---

# 🏗 Arquitetura

O projeto utiliza **Arquitetura Hexagonal (Ports & Adapters)**.

O princípio principal:

> O domínio da aplicação não depende de frameworks, banco de dados ou serviços externos.

A Steam API, PostgreSQL, Redis e qualquer outro serviço externo são apenas detalhes de infraestrutura.

```text
                    Steam Web API
                         |
                         |
                Steam API Adapter
                         |
                         |
+------------------------------------------------+
|                                                |
|              Application Core                  |
|                                                |
|   Use Cases | CQRS | Commands | Queries        |
|                                                |
+------------------------------------------------+
                         |
                         |
                 Domain Core
                         |
        Entities | Value Objects | Rules
                         |
                         |
+------------------------------------------------+
|              Infrastructure                    |
|                                                |
| PostgreSQL | Redis | Authentication | Logging  |
|                                                |
+------------------------------------------------+
```

---

# 🧱 Stack Tecnológica

## Backend

* C#
* .NET 9
* ASP.NET Core Web API
* Entity Framework Core
* PostgreSQL
* Redis
* MediatR
* FluentValidation
* Serilog
* OpenTelemetry
* Swagger/OpenAPI
* Docker

---

## Frontend

* Angular
* TypeScript
* Angular Standalone Components
* Signals
* RxJS
* Angular Material
* TailwindCSS
* NgRx Signal Store

---

## Testes

### Backend

* xUnit
* FluentAssertions
* NSubstitute
* Testcontainers

### Frontend

* Jest
* Cypress

---

# 📂 Estrutura da Solution

```text
SteamAchievementTracker

├── src
│
│── Api
│
│── Domain
│   ├── Entities
│   ├── ValueObjects
│   ├── Aggregates
│   ├── Events
│   ├── Exceptions
│   └── Rules
│
│── Application
│   └── Features
│       ├── Players
│       ├── Library
│       ├── Achievements
│       └── Statistics
│
│── Infrastructure
│   ├── Persistence
│   ├── Steam
│   ├── Cache
│   ├── Authentication
│   └── Logging
│
│── SharedKernel
│
│── Worker
│
├── tests
│
│── Domain.Tests
│── Application.Tests
│── Infrastructure.Tests
│── Api.Tests
│
└── frontend
    ├── core
    ├── features
    ├── shared
    ├── layouts
    └── components
```

---

# 🧩 Padrão Vertical Slice Architecture

As funcionalidades são organizadas por domínio e caso de uso.

Exemplo:

```text
Application

Features

├── Library

│   ├── ImportLibrary

│   ├── GetLibrary

│   └── SyncLibrary


├── Achievements

│   ├── GetAchievements

│   ├── SyncAchievements

│   └── CalculateProgress


└── Players

    ├── GetProfile

    └── ComparePlayers
```

Cada funcionalidade contém:

* Command/Query
* Handler
* Validator
* DTOs
* Regras específicas

---

# 🎯 Funcionalidades

## 👤 Perfil Steam

* Login utilizando Steam OpenID.
* Importação do perfil.
* Sincronização automática.
* Histórico do jogador.

---

# 🎮 Biblioteca Steam

Dashboard contendo:

* Total de jogos.
* Horas jogadas.
* Jogos nunca iniciados.
* Jogos mais jogados.
* Jogos favoritos.
* Evolução da biblioteca.

---

# 🏆 Achievement Tracker

Sistema completo de acompanhamento:

* Achievements desbloqueados.
* Achievements restantes.
* Percentual de conclusão.
* Barra de progresso.
* Última conquista obtida.
* Jogos próximos de 100%.
* Jogos completos.

---

# 📊 Analytics

Métricas geradas:

* Taxa média de conclusão.
* Jogos finalizados.
* Achievements raros.
* Ranking pessoal.
* Tempo investido.
* Evolução mensal.

---

# 👥 Comparação entre Jogadores

Possibilidade de comparar:

* Biblioteca.
* Horas jogadas.
* Achievements.
* Jogos em comum.
* Percentual de conclusão.

---

# 🤖 Inteligência Artificial

Funcionalidades futuras:

* Recomendações personalizadas.
* Análise de perfil gamer.
* Sugestão de próximos jogos.
* Explicação inteligente de recomendações.

Exemplo:

> "Você completou jogos de estratégia e gerenciamento. Baseado no seu histórico, este jogo possui alta compatibilidade."

---

# 🔌 Integrações

## Steam Web API

Dados utilizados:

* Perfil do jogador.
* Biblioteca.
* Jogos.
* Estatísticas.
* Achievements.

---

# 🗄 Modelo Inicial de Domínio

```text
Player

 └── SteamProfile


Game

 └── Achievements


PlayerAchievement

 └── CompletionStatus
```

---

# ⚙️ Infraestrutura

Ambiente utilizando Docker:

```text
Docker Compose

├── API (.NET)
├── Angular
├── PostgreSQL
├── Redis
└── Seq
```

---

# 🔍 Observabilidade

Implementado:

* Logs estruturados.
* Tracing distribuído.
* Métricas.
* Monitoramento de erros.

Tecnologias:

* Serilog
* OpenTelemetry
* Seq
* Jaeger

---

# 🔐 Segurança

Implementações:

* Steam OpenID Authentication.
* JWT quando necessário.
* Validação de entrada.
* Rate limiting.
* Tratamento global de exceções.

---

# 🛣 Roadmap

## Fase 1 — Fundação

* [ ] Criar arquitetura base.
* [ ] Configurar Docker.
* [ ] Configurar PostgreSQL.
* [ ] Configurar Redis.
* [ ] Criar domínio inicial.
* [ ] Criar pipeline CI/CD.

---

## Fase 2 — Steam Integration

* [ ] Steam OpenID.
* [ ] Cliente Steam API.
* [ ] Sincronização de biblioteca.
* [ ] Persistência dos jogos.

---

## Fase 3 — Achievement System

* [ ] Importar achievements.
* [ ] Dashboard.
* [ ] Estatísticas.
* [ ] Progresso.

---

## Fase 4 — Evolução

* [ ] Comparação entre jogadores.
* [ ] Gamificação.
* [ ] Steam Wrapped.
* [ ] IA.
* [ ] Aplicativo mobile.

---

# 🧪 Qualidade

Práticas utilizadas:

* Clean Code.
* SOLID.
* Code Review.
* Testes automatizados.
* Conventional Commits.
* CI/CD.
* Documentação técnica.

---

# 📚 Conceitos Aplicados

Este projeto explora:

* Arquitetura Hexagonal.
* Domain-Driven Design.
* CQRS.
* Vertical Slice Architecture.
* Repository Pattern.
* Dependency Injection.
* Domain Events.
* Result Pattern.
* Specification Pattern.
* Cache distribuído.
* Integração com APIs externas.

---

# 📌 Status

🚧 Em desenvolvimento.

---

# 📄 Licença

MIT License.

---

# 👨‍💻 Sobre

Projeto desenvolvido com foco em aprendizado avançado de arquitetura de software, engenharia backend e desenvolvimento full stack moderno utilizando **C# + Angular**.
