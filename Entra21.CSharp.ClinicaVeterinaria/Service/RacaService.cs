using Entra21.CSharp.ClinicaVeterinaria.Repositorio;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Service.ViewModels;

namespace Entra21.CSharp.ClinicaVeterinaria.Service
{
    // A classe RacaService irá implementar a interface IRacaService,
    // ou seja, deverá honrar as clausulas definidas na interface(contrato)
    public class RacaService : IRacaService
    {
        private readonly IRacaRepositorio _racaRepositorio;

        // Construir o objeto de RacaServico com o mínimo para a correta execução
        public RacaService(ClinicaVeterinariaContexto contexto)
        {
            _racaRepositorio = new RacaRepositorio(contexto);
        }

        public void Editar(RacaEditarViewModel racaEditarViewModel)
        {
            var raca = new Raca();
            raca.Id = racaEditarViewModel.Id;
            raca.Nome = racaEditarViewModel.Nome.Trim();
            raca.Especie = racaEditarViewModel.Especie;

            _racaRepositorio.Atualizar(raca);
        }

        public void Apagar(int id)
        {
            _racaRepositorio.Apagar(id);
        }

        public void Cadastrar(RacaCadastrarViewModel racaCadastrarViewModel)
        {
            var raca = new Raca();
            raca.Nome = racaCadastrarViewModel.Nome;
            raca.Especie = racaCadastrarViewModel.Especie;

            _racaRepositorio.Cadastrar(raca);
        }

        public Raca ObterPorId(int id)
        {
            var raca = _racaRepositorio.ObterPorId(id);

            return raca;
        }

        public List<Raca> ObterTodos()
        {
            var racasDoBanco = _racaRepositorio.ObterTodos();

            return racasDoBanco;
        }
    }
}