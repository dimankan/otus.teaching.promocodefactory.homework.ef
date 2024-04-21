using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbContext Context;

        private readonly DbSet<T> _entitySet;

        protected EfRepository(DbContext context)
        {
            Context = context;
            _entitySet = Context.Set<T>();
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _entitySet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _entitySet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            return (await _entitySet.AddAsync(entity)).Entity;
        }

        public virtual async Task DeleteAsync(T entity)
        {
            _entitySet.Remove(entity);
            await SaveChangesAsync();
        }

        public virtual async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
