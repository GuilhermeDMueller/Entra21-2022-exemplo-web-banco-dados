using Entra21.CSharp.ClinicaVeterinaria.Service;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplication.Controllers
{
    // Dois pontos Herança(mais para frente)
    public class RacaController : Controller
    {
        private RacaService racaService;
        // Construtor: objetivo construir o objeto de RacaControler, com o mínino
        // necessário para o funcionário correto
        public RacaController()
        {
            racaService = new RacaService();
        }
        /// <summary>
        /// Endpoitn que permite listar todas as raças
        /// </summary>
        /// <returns>Retorna a página html com as raças</returns>
        [Route("/raca")]
        [HttpGet]
        public IActionResult ObterTodos()
        {
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
            racaService.Cadastrar(nome, especie);
        
            return RedirectToAction("Index");
        }

    }
}