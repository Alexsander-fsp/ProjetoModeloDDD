using PrimeiroModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroModelo.Domain.Interfaces.Services
{
    public interface IColaboradorDomainService
    {
        void Atualizar(Colaborador colaborador);
        void Deletar(int id);
        List<Colaborador> GetAll();
        Colaborador GetById(int id);
        void Salvar(Colaborador colaborador);
    }
}
