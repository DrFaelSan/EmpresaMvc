using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmpresaMvc.ApplicationCore.Interfaces.Repositorys
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetById(int Id);
        List<TEntity> Search(Expression<Func<TEntity, bool>> Predicate );
    }
}
