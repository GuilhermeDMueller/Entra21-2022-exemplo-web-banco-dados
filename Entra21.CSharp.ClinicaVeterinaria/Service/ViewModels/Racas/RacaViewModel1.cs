using System.ComponentModel.DataAnnotations;

namespace Entra21.CSharp.ClinicaVeterinaria.Service.ViewModels.Racas
{
    public class RacaViewModel
    {
        //[Display(Name = "Nome")]
        [Display(Name = nameof(Nome))]
        [Required(ErrorMessage = "{0}Nome deve ser preenchido")]
        [MinLength(4, ErrorMessage = "{0}Nome deve conter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "{0}Nome deve conter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Espécie Animal")]
        [Required(ErrorMessage = "Espécie deve ser escolhida")]
        public string Especie { get; set; }
    }
}