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
        List<Colaborador> GetAll();
        void Salvar(Colaborador colaborador);
    }
}
