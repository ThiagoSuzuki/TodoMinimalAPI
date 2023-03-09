using Microsoft.EntityFrameworkCore;

class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}

// define o contexto do banco de dados, classe principal que coordena a funcionalidade do EF para modelo de dados
// classe derivada de Microsoft.EntityFrameworkCore.DbContext