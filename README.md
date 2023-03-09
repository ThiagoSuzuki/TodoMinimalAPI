# TodoAPI

Uma pequena aplicação usando uma API HTTP com ASP.NET Core com mínimo de dependências e recursos básicos para microsserviços.

| API (endpoint)          | Descrição                                 |
|-------------------------|-------------------------------------------|
| GET /todoitems          | Busca todos os itens de tarefas pendentes |
| GET /todoitems/complete | Busca todos os itens pendentes concluídos |
| GET /todoitems/{id}     | Buscar um item pelo Id                    |
| POST /todoitems         | Adiciona um novo item                     |
| PUT /todoitems/{id}     | Atualiza um item existente                |
| DELETE /todoitems/{id}  | Exclui um item pelo ID                    |

### Ferramentas usadas:

<p>Entity Framework Core: para o contexto do banco de dados</p>
<p>Postman: para o teste das endpoints na API</p>
