using PrimeiroModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroModelo.Domain.Interfaces
{
    class IProdutoRepository : IRepositoryBase<Produto>
    {
        public void Add(Produto obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Produto GetById(int obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Produto obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Produto obj)
        {
            throw new NotImplementedException();
        }
    }
}
