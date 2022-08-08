using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.CSharp.ClinicaVeterinaria.Service
{
    // A classe RacaService irá implementar a interface IRacaService,
    // ou seja, deverá honrar as clausulas definidas na interface(contrato)
    public class RacaService : IRacaService
    {
        public void Cadastrar(string nome, string especie )
        {
            Console.WriteLine($"Nome: {nome} espécie: {especie}");
        }
    }
}
