using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Service.ViewModels.Veterinarios;

namespace Entra21.CSharp.ClinicaVeterinaria.Service.MapeamentosEntidades
{
    public class VeterinarioMapeamentoEntidade : IVeterinarioMapeamentoEntidade
    {
        public Veterinario ConstruirCom(VeterinarioCadastrarViewModel viewModel)
        {
            return new Veterinario
            {
                Nome = viewModel.Nome,
                Crmv = viewModel.Crmv
            };
        }
    }
}