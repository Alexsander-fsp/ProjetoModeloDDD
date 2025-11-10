using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PrimeiroModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(c => c.ProdutoId);
            Property(c => c.Nome).IsRequired().HasMaxLength(150);
            Property(c => c.Valor).IsRequired();
        }
    }
}
