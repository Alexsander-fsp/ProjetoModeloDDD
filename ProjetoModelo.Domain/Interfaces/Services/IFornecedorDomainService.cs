using PrimeiroModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroModelo.Domain.Interfaces.Services
{
    public interface IFornecedorDomainService
    {
        void Atualizar(Fornecedor fornecedor);
        void Excluir(int id);
        List<Fornecedor> GetAll();
        Fornecedor GetById(int id);
        void Salvar(Fornecedor fornecedor);
    }
}
