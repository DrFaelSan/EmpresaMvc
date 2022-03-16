using EmpresaMvc.ApplicationCore.Entitys;
using EmpresaMvc.ApplicationCore.Interfaces.Repositorys;
using EmpresaMvc.Infrastructure.Data;

namespace EmpresaMvc.Infrastructure.Repository
{
    public class CompanyRepository : EFRepository<Company> ,ICompanyRepository
    {
        public CompanyRepository(CompanyContext context) : base(context) { }

    }
}
