using FIlmesLeoesDeJuda.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly FilmesLeoesDeJudaContext _ctx;

        public Repository(FilmesLeoesDeJudaContext ctx)
        {
            _dbSet = ctx.Set<T>();
            _ctx = ctx;
        }

        public async Task Adicionar(T entity)
        {
            await _dbSet.AddAsync(entity);
            SaveChanges();
        }
        
        public void Atualizar(T entity)
        {
            _dbSet.Update(entity);
            SaveChanges();
        }

        public async Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<T> ObterPorId(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> ObterTodos()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Remover(Guid id)
        {
            _dbSet.Remove(await ObterPorId(id));

            SaveChanges();
        }

        private void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }

}
