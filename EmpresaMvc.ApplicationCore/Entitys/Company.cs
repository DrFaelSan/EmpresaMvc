using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaMvc.ApplicationCore.Entitys
{

    /// <summary>
    /// My Class Company is equal my table Empresas in DataBase.
    /// </summary>
    public class Company
    {

        #region Properties

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome da empresa é obrigatório", AllowEmptyStrings = false)]
        [Column("Nome",Order = 1)]
        public string Name { get; set; }

        [Column("Site",Order = 2)]
        public string Site { get; set; }

        [Column("QuantidadeFuncionarios", Order = 3)]
        [Display(Name = "Quantidade Funcionários")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Informe somente números")]
        public int NumberEmployees { get; set; }

        #endregion

        #region Constructors
        public Company() { }

        #endregion

    }
}
