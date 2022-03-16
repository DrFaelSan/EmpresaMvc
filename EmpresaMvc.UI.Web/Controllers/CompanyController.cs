using EmpresaMvc.ApplicationCore.Entitys;
using EmpresaMvc.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NToastNotify;
using System.Linq;

namespace EmpresaMvc.UI.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly ICompanyServices _companyServices;
        private readonly IToastNotification _toastNotification;


        public CompanyController(ILogger<CompanyController> logger, ICompanyServices company, IToastNotification toastNotification)
        {
            _logger = logger;
            _companyServices = company;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }  
        
        [HttpPost]
        public IActionResult Create(Company company)
        {
            _toastNotification.AddAlertToastMessage($"A Empresa {company.Name} foi criada com sucesso!");
            return View(_companyServices.Add(company));
        }

        
        public IActionResult Delete([FromQuery]int? id)
        {
            Company company = _companyServices.GetById(id ?? 0);
            return View(company);
        }

        [HttpPost]
        public IActionResult Delete(Company company)
        {

            Company companyDelete = _companyServices.Search(c => c.Name == company.Name).FirstOrDefault();
            _companyServices.Delete(companyDelete);
            _toastNotification.AddAlertToastMessage($"A Empresa {company.Name} foi apagada com sucesso!");
            return RedirectToAction("ViewAll");

        }


        public IActionResult Update([FromQuery] int? id)
        {
            Company company = _companyServices.GetById(id ?? 0);

            return View(company);
        }

        [HttpPost]
        public IActionResult Update(Company company)
        {
            _companyServices.Update(company);
            _toastNotification.AddSuccessToastMessage($"A Empresa {company.Name} foi atulizada com sucesso!");
            return View(company);
        }

        public IActionResult ViewAll()
        {
            return View(_companyServices.GetAll());
        }
    }
}
