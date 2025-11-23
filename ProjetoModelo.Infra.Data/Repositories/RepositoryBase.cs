using PrimeiroModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        internal readonly ProjetoModeloContext _projetoModeloContext;

        public RepositoryBase(ProjetoModeloContext projetoModeloContext)
        {
            _projetoModeloContext = projetoModeloContext;
        }

        public void Add(TEntity obj)
        {
            _projetoModeloContext.Set<TEntity>().Add(obj);
            _projetoModeloContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _projetoModeloContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _projetoModeloContext.Set<TEntity>().Find(id);            
        }

        public void Remove(TEntity obj)
        {
            _projetoModeloContext.Entry(obj).State = EntityState.Deleted;
            _projetoModeloContext.SaveChanges();
        }

        public void RemoveById(int id)
        {
            var entity = GetById(id);

            _projetoModeloContext.Entry(entity).State = EntityState.Deleted;
            _projetoModeloContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _projetoModeloContext.Entry(obj).State = EntityState.Modified;
            _projetoModeloContext.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
