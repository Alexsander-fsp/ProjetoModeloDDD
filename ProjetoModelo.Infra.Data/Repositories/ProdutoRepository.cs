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
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoInfraDataRepository
    {
        public ProdutoRepository(ProjetoModeloContext projetoModeloContext) : base(projetoModeloContext)
        {

        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _projetoModeloContext.Produto.Where(p => p.Nome == nome);
        }
        
    }
}
