using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.Repositories
{
    class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produto.Where(p => p.Nome == nome);
        }
    }
}
