using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Repositories;
using PrimeiroModelo.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace PrimeiroModelo.Domain.Services
{
    public class FornecedorDomainService : IFornecedorDomainService
    {
        private readonly IFornecedorInfraDataRepository _fornecedorInfraDataRepository;

        public FornecedorDomainService(IFornecedorInfraDataRepository fornecedorRepository)
        {
            _fornecedorInfraDataRepository = fornecedorRepository;
        }
        public List<Fornecedor> GetAll()
        {
            return _fornecedorInfraDataRepository.GetAll().ToList();
        }

        public void Salvar(Fornecedor fornecedor)
        {
            _fornecedorInfraDataRepository.Add(fornecedor);
        }

        public Fornecedor GetById(int id)
        {
            var fornecedor = _fornecedorInfraDataRepository.GetById(id);

            return fornecedor;
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            _fornecedorInfraDataRepository.Update(fornecedor);
        }

        public void Excluir(int id)
        {
            _fornecedorInfraDataRepository.RemoveById(id);
        }
    }
}
