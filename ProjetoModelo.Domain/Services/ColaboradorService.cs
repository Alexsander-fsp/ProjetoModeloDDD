using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Repositories;
using PrimeiroModelo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeiroModelo.Domain.Services
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorService(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }
        public List<Colaborador> GetAll()
        {
            return _colaboradorRepository.GetAll().ToList();
        }
    }
}
