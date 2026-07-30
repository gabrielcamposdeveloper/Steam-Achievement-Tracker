# 🎮 Steam Achievement Tracker

Uma aplicação web para acompanhar, analisar e visualizar o progresso de Achievements da Steam através da **Steam Web API**.

O projeto permite que usuários consultem estatísticas detalhadas da sua biblioteca, acompanhem o progresso dos jogos, comparem perfis e descubram quais conquistas estão mais próximas de serem concluídas.

---

# 📌 Objetivos

* Consumir a Steam Web API.
* Centralizar informações sobre Achievements.
* Gerar estatísticas da biblioteca.
* Exibir dashboards interativos.
* Comparar progresso entre jogadores.
* Demonstrar conhecimentos em arquitetura de software, APIs REST e desenvolvimento Full Stack.

---

# ✨ Funcionalidades

## 📊 Dashboard

* Total de jogos da biblioteca
* Jogos com Achievements
* Horas totais jogadas
* Percentual médio de conclusão
* Jogos 100%
* Jogos próximos de 100%
* Jogos abandonados
* Achievements desbloqueados
* Achievements restantes

---

## 🏆 Achievement Tracker

Para cada jogo será exibido:

* Nome
* Capa
* Horas jogadas
* Total de Achievements
* Achievements conquistados
* Percentual de conclusão
* Barra de progresso
* Última conquista desbloqueada

---

## 📈 Estatísticas

* Jogos mais completos
* Jogos menos completos
* Achievements raros
* Jogos nunca iniciados
* Média de conclusão
* Distribuição por gênero
* Ranking dos jogos mais jogados

---

## 👥 Comparação entre Usuários

Comparação entre dois perfis públicos da Steam.

Será possível visualizar:

* Jogos em comum
* Quem possui mais horas
* Quem possui mais Achievements
* Percentual de conclusão
* Ranking

---

## 🎯 Recomendações

O sistema poderá sugerir:

* Jogos próximos de 100%
* Achievements fáceis
* Jogos esquecidos
* Próximos objetivos

---

## 📄 Relatórios

Exportação em:

* PDF
* CSV

---

# 🛠 Tecnologias

## Backend

* ASP.NET Core 9
* Entity Framework Core
* PostgreSQL
* Redis
* Swagger

## Frontend

* React
* TypeScript
* Tailwind CSS
* React Query
* Recharts

## Infraestrutura

* Docker
* Docker Compose
* GitHub Actions

---

# 🏗 Arquitetura

```text
Steam Achievement Tracker

        React

          │

 REST API (ASP.NET Core)

          │

   Application Layer

          │

     Domain Layer

          │

 Infrastructure Layer

          │

 PostgreSQL + Redis

          │

 Steam Web API
```

---

# 📂 Estrutura do Projeto

```text
src/

 ├── SteamTracker.API
 ├── SteamTracker.Application
 ├── SteamTracker.Domain
 ├── SteamTracker.Infrastructure
 ├── SteamTracker.Persistence
 ├── SteamTracker.Shared

frontend/

 ├── components
 ├── pages
 ├── hooks
 ├── services
 ├── layouts
 ├── assets
```

---

# 🔑 Integração com a Steam

A aplicação utiliza a Steam Web API para obter:

* Perfil do jogador
* Biblioteca
* Horas jogadas
* Lista de Achievements
* Estatísticas globais
* Informações dos jogos

---

# 📸 Telas Planejadas

* Dashboard
* Biblioteca
* Detalhes do jogo
* Comparação entre usuários
* Estatísticas
* Perfil
* Configurações

---

# 🚀 Roadmap

## Versão 1.0

* [ ] Login utilizando Steam OpenID
* [ ] Importação da biblioteca
* [ ] Dashboard
* [ ] Lista de jogos
* [ ] Progresso dos Achievements

---

## Versão 1.1

* [ ] Comparação entre usuários
* [ ] Dashboard avançado
* [ ] Histórico de progresso
* [ ] Exportação em PDF

---

## Versão 2.0

* [ ] Recomendações com IA
* [ ] Steam Wrapped
* [ ] Ranking entre amigos
* [ ] Notificações
* [ ] Aplicativo mobile

---

# 🎯 Objetivos Técnicos

Este projeto foi desenvolvido para praticar:

* Arquitetura Limpa (Clean Architecture)
* SOLID
* Domain-Driven Design (DDD)
* Consumo de APIs REST
* Entity Framework Core
* Cache com Redis
* Docker
* Autenticação
* Testes unitários
* Integração contínua (CI/CD)

---

# 📚 Aprendizados

Durante o desenvolvimento serão explorados conceitos como:

* Integração com APIs externas
* Modelagem de domínio
* Persistência de dados
* Cache
* Tratamento de erros
* Visualização de dados
* Performance
* Boas práticas de arquitetura

---

# 📌 Status

🚧 Em desenvolvimento.

---

# 🤝 Contribuição

Contribuições são bem-vindas. Sinta-se à vontade para abrir uma *Issue* ou enviar um *Pull Request*.

---

# 📄 Licença

Este projeto é distribuído sob a licença MIT.

---

> **Observação:** O acesso aos dados depende das configurações de privacidade do perfil Steam do usuário. Algumas informações podem não estar disponíveis para perfis privados.
