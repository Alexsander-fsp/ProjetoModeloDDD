using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Repositories;
using PrimeiroModelo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeiroModelo.Domain.Services
{
    public class ColaboradorDomainService : IColaboradorDomainService
    {
        private readonly IColaboradorInfraDataRepository _colaboradorInfraDataRepository;

        public ColaboradorDomainService(IColaboradorInfraDataRepository colaboradorRepository)
        {
            _colaboradorInfraDataRepository = colaboradorRepository;
        }

        public void Atualizar(Colaborador colaborador)
        {
            _colaboradorInfraDataRepository.Update(colaborador);
        }

        public void Deletar(int id)
        {
            _colaboradorInfraDataRepository.RemoveById(id);
        }
        
        public List<Colaborador> GetAll()
        {
            return _colaboradorInfraDataRepository.GetAll().ToList();
        }

        public Colaborador GetById(int id)
        {
            var colaborador = _colaboradorInfraDataRepository.GetById(id);
            return colaborador;
        }

        public void Salvar(Colaborador colaborador)
        {
            _colaboradorInfraDataRepository.Add(colaborador);
        }
    }
}
