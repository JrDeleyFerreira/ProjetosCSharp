using AluraFilmesEntity.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AluraFilmesEntity.controller
{
  internal class AtorConfiguration : IEntityTypeConfiguration<Ator>
  {
    public void Configure(EntityTypeBuilder<Ator> builder)
    {
      /** Configurações iniciais */
      builder.ToTable("actors");
      builder.Property(p => p.Id).HasColumnName("actor_id");
      builder.Property(p => p.Nome).HasColumnName("first_name").HasColumnType("varchar(45)").IsRequired();
      builder.Property(p => p.Sobrenome).HasColumnName("last_name").HasColumnType("varchar(45)").IsRequired();

      /** Shadow Properties */
      builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();

      /** Criar índices para a tabela */
      builder.HasIndex(i => i.Sobrenome).HasDatabaseName("idx_actor_last_name");

      /** Restrição de homônimos com "chave alternativa" */
      builder.HasAlternateKey(k => new { k.Nome, k.Sobrenome });
      
    }
  }
}