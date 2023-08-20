using AluraFilmesEntity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AluraFilmesEntity.Controller
{
  class FuncionarioConfiguration : PessoaConfiguration<Funcionario>
  {
    /// <summary>
    /// Essas configurações das propriedades do objeto EntityTypeBuilder<>, 
    /// são a substituição das DataAnnotations (decorações), na classe modelo.
    /// </summary>
    /// <param name="builder">EntityTypeBuilder<> tipado</param>
    public override void Configure(EntityTypeBuilder<Funcionario> builder)
    {
      /** HERANÇA */
      base.Configure(builder);

      /** Configurações Iniciais */
      builder.ToTable("staff");
      builder.Property(p => p.Id).HasColumnName("staff_id");
      builder.Property(p => p.Login).HasColumnName("username").HasColumnType("varchar(16)").IsRequired();
      builder.Property(p => p.Senha).HasColumnName("password").HasColumnType("varchar(16)");
      
    }
  }
}
