using PrimeiroModelo.Domain.Entities;
using ProjetoModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("Produto");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).IsRequired().HasMaxLength(150);
            Property(p => p.Valor).IsRequired();
            HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.ClienteProduto);
        }
    }
}
