using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpresaMvc.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void initialize(CompanyContext context)
        {
            if(context.Companies.Any())
            {
                return;
            }
        }
    }
}
