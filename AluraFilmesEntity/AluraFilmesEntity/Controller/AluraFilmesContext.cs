using AluraFilmesEntity.Controller;
using AluraFilmesEntity.model;
using AluraFilmesEntity.Model;
using Microsoft.EntityFrameworkCore;

namespace AluraFilmesEntity.controller
{
  public class AluraFilmesContext : DbContext
  {
    public DbSet<Ator> Atores { get; set; }
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Idiomas> Idiomas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;DATABASE=AluraFilmes;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new AtorConfiguration());
      modelBuilder.ApplyConfiguration(new FilmeConfiguration());
      modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
      modelBuilder.ApplyConfiguration(new IdiomasConfiguration());

      /** Mapear Cliente e Funcionário, que são filhos de "Pessoa", não
       * configura propriamente Herança do Entity, porém, EntityCore ainda 
       * não implementa outros padrões:
       * TPH => Apenas uma tabela para TODOS os filhos 
       * TPC => Uma tabel por classe concreta - NÃO SUPORTADO
       * TPT => Cada tipo tem a sua tabela - NÃO SUPORTADO */
      modelBuilder.ApplyConfiguration(new ClienteConfiguration());
      modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
    }
  }
}
