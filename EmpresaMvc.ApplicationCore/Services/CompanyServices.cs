using EmpresaMvc.ApplicationCore.Entitys;
using EmpresaMvc.ApplicationCore.Interfaces.Repositorys;
using EmpresaMvc.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EmpresaMvc.ApplicationCore.Services
{
    /// <summary>
    /// Business Rule of my class Company
    /// </summary>
    public class CompanyServices : ICompanyServices
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyServices(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }


        public Company Add(Company entity)
        {
           //TODO: implements business rules 
           return _companyRepository.Add(entity);
        }

        public void Delete(Company entity)
        {
           _companyRepository.Delete(entity);
        }

        public List<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }

        public Company GetById(int Id)
        {
            if(Id > 0)
                return _companyRepository.GetById(Id);  
            return null;
        }

        public List<Company> Search(Expression<Func<Company, bool>> Predicate)
        {
            return _companyRepository.Search(Predicate);
        }

        public void Update(Company entity)
        {
            _companyRepository.Update(entity);
        }
    }
}
