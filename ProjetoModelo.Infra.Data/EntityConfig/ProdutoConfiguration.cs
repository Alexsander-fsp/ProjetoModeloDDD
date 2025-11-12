using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProjetoModelo.Domain.Entities;
using PrimeiroModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);
            Property(p => p.Nome).IsRequired().HasMaxLength(150);
            Property(p => p.Valor).IsRequired();
            HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.ClienteProduto);
        }
    }
}
