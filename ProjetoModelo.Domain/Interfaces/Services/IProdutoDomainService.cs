using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroModelo.Domain.Interfaces.Services
{
    public interface IProdutoDomainService
    {
        void Add(Produto produto);
        void Atualizar(Produto produto);
        void Excluir(int id);
        List<Produto> GetAll();
        Produto GetById(int id);
    }
}
