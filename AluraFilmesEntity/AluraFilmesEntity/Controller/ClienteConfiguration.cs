using AluraFilmesEntity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AluraFilmesEntity.Controller
{
  public class ClienteConfiguration : PessoaConfiguration<Cliente>
  {
    public override void Configure(EntityTypeBuilder<Cliente> builder)
    {
      /** HERANÇA */
      base.Configure(builder);

      /** Configurações iniciais */
      builder.ToTable("customer");
      builder.Property(p => p.Id).HasColumnName("customer_id");

      /** Shadow Properties */
      builder.Property<DateTime>("create_date").HasColumnType("datetime").HasDefaultValueSql("getdate()");
    }
  }
}
