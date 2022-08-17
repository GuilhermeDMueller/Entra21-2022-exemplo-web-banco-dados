using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Enums;
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
            ViewBag.Racas = racas;

            return View("Index");
        }

        [Route("/raca/cadastrar")]
        [HttpGet]

        public IActionResult Cadastrar()
        {
            var especies = ObterEspecies();

            ViewBag.Especies = especies;

            return View();
        }

        [Route("/raca/cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar(
            [FromForm] string nome,
            [FromForm] string especie)
        {
            _racaService.Cadastrar(nome, especie);

            return RedirectToAction("Index");
        }
        [Route("/raca/apagar")]
        [HttpGet]
        // https://localhost:porta/raca/apagar?id=4
        public IActionResult Apagar([FromQuery]int id)
        {
            _racaService.Apagar(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/raca/editar")]
        public IActionResult Editar([FromQuery]int id)
        {
            var raca = _racaService.ObterPorId(id);
            var especies = ObterEspecies();

            ViewBag.Raca = raca;
            ViewBag.Especies = especies;

            return View("Editar");
        }

        [HttpPost]
        [Route("/raca/editar")]
        public IActionResult Editar(
            [FromForm] int id,
            [FromForm] string nome,
            [FromForm] string especie)
        {
            _racaService.Editar(id, nome, especie);

            return RedirectToAction("Index");
        }

        private List<string> ObterEspecies()
        {
            return Enum.GetNames<Especie>().OrderBy(x => x).ToList();
        }
    }
}