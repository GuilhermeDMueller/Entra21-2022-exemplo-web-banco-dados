using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Service.ViewModels.Veterinarios;

namespace Entra21.CSharp.ClinicaVeterinaria.Service
{
    public interface IVeterinarioServico
    {
        Veterinario Cadastrar(VeterinarioCadastrarViewModel viewModel);
        IList<Veterinario> ObterTodos(string pesquisa);
    }
}