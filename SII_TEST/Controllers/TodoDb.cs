using Microsoft.EntityFrameworkCore;
using SII_TEST.Models;

class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<employee> Todos => Set<employee>();
}
