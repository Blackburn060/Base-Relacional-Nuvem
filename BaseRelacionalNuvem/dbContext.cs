using Microsoft.EntityFrameworkCore;

public class dbContext : DbContext
{
    public DbSet<Curso> Curso { get; set; }
    public DbSet<Estudante> Estudantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=escola;User Id=root;Password=suaSenha;",
            new MySqlServerVersion(new Version(8, 0, 25)));
    }
}
