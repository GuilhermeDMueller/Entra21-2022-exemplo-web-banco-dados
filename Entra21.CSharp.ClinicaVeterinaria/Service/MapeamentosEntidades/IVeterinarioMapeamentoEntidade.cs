using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Service.ViewModels.Veterinarios;

namespace Entra21.CSharp.ClinicaVeterinaria.Service.MapeamentosEntidades
{
    public interface IVeterinarioMapeamentoEntidade
    {
        Veterinario ConstruirCom(VeterinarioCadastrarViewModel viewModel);
    }
}