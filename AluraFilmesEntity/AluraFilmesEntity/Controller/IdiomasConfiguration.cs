using AluraFilmesEntity.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AluraFilmesEntity.controller
{
  internal class IdiomasConfiguration : IEntityTypeConfiguration<Idiomas>
  {
    public void Configure(EntityTypeBuilder<Idiomas> builder)
    {
      /** Configurações iniciais */
      builder.ToTable("languages");
      builder.Property(p => p.Id).HasColumnName("language_id");
      builder.Property(p => p.Nome).HasColumnName("name").HasColumnType("char(20)").IsRequired();

      /** Shadow Properties */
      builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();

    }
  }
}