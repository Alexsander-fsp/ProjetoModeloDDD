using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Repositories;
using PrimeiroModelo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroModelo.Domain.Services
{
    public class ProdutoDomainService : IProdutoDomainService
    {
        private readonly IProdutoInfraDataRepository _produtoInfraDataRepository;
        public ProdutoDomainService(IProdutoInfraDataRepository produtoRepository)
        {
            _produtoInfraDataRepository = produtoRepository;
        }

        public List<Produto> GetAll()
        {
           return _produtoInfraDataRepository.GetAll().ToList();
        }
    }
}
