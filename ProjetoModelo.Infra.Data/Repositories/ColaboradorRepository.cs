using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Infra.Data.Context;

namespace ProjetoModelo.Infra.Data.Repositories
{
    public class ColaboradorRepository : RepositoryBase<Colaborador>, IColaboradorRepository
    {
        public ColaboradorRepository(ProjetoModeloContext projetoModeloContext) : base(projetoModeloContext) 
        {                
        }
    }
}
