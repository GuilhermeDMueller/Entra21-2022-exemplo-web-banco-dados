using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Service.ViewModels;

namespace Entra21.CSharp.ClinicaVeterinaria.Service
{
    public interface IRacaService
    {
        void Cadastrar(RacaCadastrarViewModel racaCadastrarViewModel);
        List<Raca> ObterTodos();
        void Editar(RacaEditarViewModel racaEditarViewModel);
        void Apagar(int id);
        Raca ObterPorId(int id);
    }
}