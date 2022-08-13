using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Service;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplication.Controllers
{
    // Dois pontos Herança(mais para frente)
    public class RacaController : Controller
    {
        private readonly RacaService _racaService;
        // Construtor: objetivo construir o objeto de RacaControler, com o mínino
        // necessário para o funcionário correto
        public RacaController(ClinicaVeterinariaContexto contexto)
        {
            _racaService = new RacaService(contexto);
        }
        /// <summary>
        /// Endpoitn que permite listar todas as raças
        /// </summary>
        /// <returns>Retorna a página html com as raças</returns>
        [Route("/raca")]
        [HttpGet]
        public IActionResult ObterTodos()
        {
            var racas = _racaService.ObterTodos();

            // Passar informação do C# para o html
            ViewBag["racas"] = racas;

            return View("Index");
        }

        [Route("/raca/cadastrar")]
        [HttpGet]

        public IActionResult Cadastrar()
        {
            return View();
        }

        [Route("/raca/registrar")]
        [HttpGet]

        public IActionResult Registrar(
            [FromQuery] string nome,
            [FromQuery] string especie)
        {
            _racaService.Cadastrar(nome, especie);

            return RedirectToAction("Index");
        }

    }
}