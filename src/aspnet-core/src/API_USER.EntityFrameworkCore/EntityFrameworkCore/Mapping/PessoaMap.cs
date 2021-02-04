using API_USER.Application;
using API_USER.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_USER.EntityFrameworkCore
{
  public class PessoaMap : IEntityTypeConfiguration<Pessoa>
  {
    public void Configure(EntityTypeBuilder<Pessoa> builder)
    {
      builder.ToTable("Pessoa");

      builder.Property(x => x.Nome)
             .HasMaxLength(256)
             .HasColumnName("Nome")
             .IsRequired();

      builder.Property(x => x.Cpf)
             .HasMaxLength(11)
             .HasColumnName("Cpf")
             .IsRequired();

      builder.Property(x => x.DataNasc)
             .HasMaxLength(8)
             .HasColumnName("DataNasc")
             .IsRequired();

      builder.HasKey(x => x.Id);
      builder.Property(x => x.Id)
             .HasColumnName("Id")
             .ValueGeneratedOnAdd();

      builder.Property(x => x.Profissao)
             .HasMaxLength(20)
             .HasColumnName("Profissao")
             .IsRequired();

      builder.Property(x => x.Nacionalidade)
             .HasMaxLength(20)
             .HasColumnName("Nacionalidade")
             .IsRequired();
      builder.Property(x => x.Telefone)
             .HasMaxLength(11)
             .HasColumnName("Telefone")
             .IsRequired();

      builder.Property(x => x.Email)
             .HasMaxLength(60)
             .HasColumnName("Email")
             .IsRequired();

    }
  }
}
