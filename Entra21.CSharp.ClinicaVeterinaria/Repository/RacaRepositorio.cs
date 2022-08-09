using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio
{
    public class RacaRepositorio : IRacaRepositorio
    {
        private readonly ClinicaVeterinariaContexto _contexto;

        public RacaRepositorio(ClinicaVeterinariaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Cadastrar(Raca raca)
        {
            Console.WriteLine($"Rep: Nome: {raca.Nome} Espécie: {raca.Especie}");
        }
    }
}