using EmpresaMvc.ApplicationCore.Interfaces.Repositorys;
using EmpresaMvc.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmpresaMvc.Infrastructure.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly CompanyContext _context;

        public EFRepository(CompanyContext context) => _context = context;

        /// <summary>
        /// Add virual in method for override.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();

        }

        public virtual List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(int Id)
        {
            return _context.Set<TEntity>().Find(Id);
        }

        public virtual List<TEntity> Search(System.Linq.Expressions.Expression<Func<TEntity, bool>> Predicate)
        {
           return _context.Set<TEntity>().Where(Predicate).ToList();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
