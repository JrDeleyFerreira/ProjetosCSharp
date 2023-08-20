using AluraFilmesEntity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AluraFilmesEntity.Controller
{
  public class PessoaConfiguration<T> : IEntityTypeConfiguration<T> where T : Pessoa
  {
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
      /** Configurações Iniciais */
      builder.Property(p => p.Nome).HasColumnName("first_name").HasColumnType("varchar(45)").IsRequired();
      builder.Property(p => p.Sobrenome).HasColumnName("last_name").HasColumnType("varchar(45)").IsRequired();
      builder.Property(p => p.Email).HasColumnName("email").HasColumnType("varchar(50)");
      builder.Property(p => p.Ativo).HasColumnName("active");

      /** Shadow Properties */
      builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()");
    }
  }
}
