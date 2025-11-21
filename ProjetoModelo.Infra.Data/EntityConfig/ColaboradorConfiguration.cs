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
    class ColaboradorConfiguration : EntityTypeConfiguration<Colaborador>
    {
        public ColaboradorConfiguration()
        {
            ToTable("Colaborador");
            HasKey(c => c.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).IsRequired().HasMaxLength(150);
            Property(c => c.Cargo).IsRequired();
            Property(c => c.Departamento).IsRequired().HasMaxLength(50);
            Property(c => c.DataAdmissao).IsRequired();
            Property(c => c.Salario).IsRequired();
            Property(c => c.Email).IsRequired().HasMaxLength(50);
            Property(c => c.Telefone).IsRequired().HasMaxLength(15);
        }
    }
}
