using EmpresaMvc.ApplicationCore.Entitys;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EmpresaMvc.ApplicationCore.Interfaces.Services
{
    public interface ICompanyServices 
    {
        Company Add(Company entity);
        void Update(Company entity);
        void Delete(Company entity);
        List<Company> GetAll();
        Company GetById(int Id);
        List<Company> Search(Expression<Func<Company, bool>> Predicate);
    }
}
