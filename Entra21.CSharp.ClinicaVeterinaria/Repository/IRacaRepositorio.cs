using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio
{
    // Crtl + R + G= Remover using desencessario
    // Ctrl + K + D= Ajeita o código
    public interface IRacaRepositorio
    {
        void Cadastrar(Raca raca);
        List<Raca> ObterTodos();
        void Atualizar(Raca racaParaAlterar);
        void Apagar(int id);
        Raca ObterPorId(int id);
    }
}