using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorInfraDataRepository
    {
        public FornecedorRepository(ProjetoModeloContext projetoModeloContext) : base(projetoModeloContext)
        {                 
        }
    }
}
