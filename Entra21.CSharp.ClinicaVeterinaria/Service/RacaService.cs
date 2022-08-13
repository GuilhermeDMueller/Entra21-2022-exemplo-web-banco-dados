using Entra21.CSharp.ClinicaVeterinaria.Repositorio;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Service
{
    // A classe RacaService irá implementar a interface IRacaService,
    // ou seja, deverá honrar as clausulas definidas na interface(contrato)
    public class RacaService : IRacaService
    {
        private RacaRepositorio _racaRepositorio;

        // Construir o objeto de RacaServico com o mínimo para a correta execução
        public RacaService(ClinicaVeterinariaContexto contexto)
        {
            _racaRepositorio = new RacaRepositorio(contexto);
        }

        public void Alterar(int id, string nome, string especie)
        {
            throw new NotImplementedException();
        }

        public void Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(string nome, string especie)
        {
            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;

            _racaRepositorio.Cadastrar(raca);

            Console.WriteLine($"Nome: {nome} espécie: {especie}");
        }

        public Raca ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Raca> ObterTodos()
        {
            var racasDoBanco = _racaRepositorio.ObterTodos();

            return racasDoBanco;
        }
    }
}