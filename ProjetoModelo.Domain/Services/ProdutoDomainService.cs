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

        public void Add(Produto produto)
        {
            _produtoInfraDataRepository.Add(produto);
        }

        public void Atualizar(Produto produto)
        {
            _produtoInfraDataRepository.Update(produto);
        }

        public void Excluir(int id)
        {
            _produtoInfraDataRepository.RemoveById(id);
        }

        public List<Produto> GetAll()
        {
           return _produtoInfraDataRepository.GetAll().ToList();
        }

        public Produto GetById(int id)
        {
            return _produtoInfraDataRepository.GetById(id);
        }
    }
}
