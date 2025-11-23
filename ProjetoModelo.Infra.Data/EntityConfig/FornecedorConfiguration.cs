using PrimeiroModelo.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModelo.Infra.Data.Context
{
    internal class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            ToTable("Fornecedor");
            HasKey(f => f.Id);
            Property(f => f.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.Nome).IsRequired().HasMaxLength(150);
            Property(f => f.CNPJ).IsRequired().HasMaxLength(20);
            Property(f => f.Telefone).IsRequired().HasMaxLength(15);
            Property(f => f.Email).IsRequired().HasMaxLength(50);
            Property(f => f.Endereco).IsRequired().HasMaxLength(200);
        }
    }
}