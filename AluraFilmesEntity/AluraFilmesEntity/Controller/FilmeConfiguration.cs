using AluraFilmesEntity.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AluraFilmesEntity.controller
{
  internal class FilmeConfiguration : IEntityTypeConfiguration<Filme>
  {
    public void Configure(EntityTypeBuilder<Filme> builder)
    {
      /** Configurações iniciais */
      builder.ToTable("films");
      builder.Property(f => f.Id).HasColumnName("film_id");
      builder.Property(f => f.Titulo).HasColumnName("title").HasColumnType("varchar(255)").IsRequired();
      builder.Property(f => f.Descricao).HasColumnName("description").HasColumnType("text");
      builder.Property(f => f.AnoLancamento).HasColumnName("release_year").HasColumnType("varchar(4)").IsRequired();
      builder.Property(f => f.Duracao).HasColumnName("lenght");
      builder.Property(f => f.TextoClassificacao).HasColumnName("rating").HasColumnType("varchar(10)");

      /** Shadow Properties */
      builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();

      /** Relac de Filmes com Idiomas */
      builder.Property<byte>("language_id");
      builder.Property<byte?>("original_language_id"); //   ? indica que pode ser NULL
      builder.HasOne(f => f.IdiomaFalado).WithMany(i => i.FilmeFalado).HasForeignKey("language_id");
      builder.HasOne(f => f.IdiomaOriginal).WithMany(i => i.FilmeOriginal).HasForeignKey("original_language_id");

      /** Propriedade existente na classe e não mapeada no banco */
      builder.Ignore(p => p.Classificacao);

    }
  }
}