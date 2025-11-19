using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces;
using ProjetoModelo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.Repositories
{
    class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
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
