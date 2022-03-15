using System.ComponentModel.DataAnnotations;

namespace EmpresaMvc.ApplicationCore.Entitys
{

    /// <summary>
    /// My Class Company is equal my table Empresas in DataBase.
    /// </summary>
    public class Company
    {
        #region Properties
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome da empresa é obrigatório", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [RegularExpression("/[-a-zA-Z0-9@:%._\"+~#=]{1,256}\".[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\"+.~#?&//=]*)?/gi", ErrorMessage = "Informe um site válido...")]
        public string Site { get; set; }

        [Display(Name = "Quantidade Funcionários")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Informe somente números")]
        public int NumberEmployees { get; set; }

        #endregion

        #region Constructors
        public Company() { }

        #endregion

    }
}
