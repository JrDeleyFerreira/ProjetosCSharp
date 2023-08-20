using AluraFilmesEntity.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AluraFilmesEntity.controller
{
  public class FilmeAtorConfiguration : IEntityTypeConfiguration<FilmeAtor>
  {
    public void Configure(EntityTypeBuilder<FilmeAtor> builder)
    {
      /** Configurações iniciais */
      builder.ToTable("films_actors");

      /** Shadow Properties */
      builder.Property<int>("film_id").IsRequired();
      builder.Property<int>("actor_id").IsRequired();
      builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()");

      /** Definição de chave composta - Relac N => N */
      builder.HasKey("actor_id", "film_id"); // OU builder.HasKey(fa => new { fa.Ator.Id, fa.Filme.Id }); Não sei se precisa do Id

      /** Definição de chave estrangeira via Shadow Properties */
      builder.HasOne(fa => fa.Filme).WithMany(a => a.AtoresFilme).HasForeignKey("film_id"); // f => f.Filme.Id na chave
      builder.HasOne(fa => fa.Ator).WithMany(f => f.Filmografia).HasForeignKey("actor_id"); // a => a.Ator.Id na chave 
    }
  }
}
