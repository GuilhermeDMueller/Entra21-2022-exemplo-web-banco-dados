using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Enums;
using Entra21.CSharp.ClinicaVeterinaria.Service;
using Entra21.CSharp.ClinicaVeterinaria.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplication.Controllers
{
    // Dois pontos Herança(mais para frente)
    public class RacaController : Controller
    {
        private readonly IRacaService _racaService;
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
            return View("Index", racas);
        }

        //[Route("/raca/cadastrar")]
        [HttpGet("/raca/cadastrar")]

        public IActionResult Cadastrar()
        {
            var especies = ObterEspecies();

            ViewBag.Especies = especies;

            ViewBag.Especies = ObterEspecies();

            var racaCadastrarViewModel = new RacaCadastrarViewModel();

            return View();
        }

        [Route("/raca/cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar(
            [FromForm] RacaCadastrarViewModel racaCadastrarViewModel)
        {
            // Valida o parâmetro recebido na Action se é inválido
            if (!ModelState.IsValid)

            {
                ViewBag.Especies = ObterEspecies();

                return View(racaCadastrarViewModel);
            }

            _racaService.Cadastrar(racaCadastrarViewModel);

            return RedirectToAction("Index");
        }
        [Route("/raca/apagar")]
        [HttpGet]
        // https://localhost:porta/raca/apagar?id=4
        public IActionResult Apagar([FromQuery] int id)
        {
            _racaService.Apagar(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/raca/editar")]
        public IActionResult Editar([FromQuery] int id)
        {
            var raca = _racaService.ObterPorId(id);
            var especies = ObterEspecies();

            var racaEditarViewModel = new RacaEditarViewModel
            {
                Id = raca.Id,
                Nome = raca.Nome,
                Especie = raca.Especie
            };

            ViewBag.Especies = especies;

            return View(racaEditarViewModel);
        }

        [HttpPost]
        [Route("/raca/editar")]
        public IActionResult Editar([FromForm] RacaEditarViewModel racaEditarViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Especies = ObterEspecies();

                return View(racaEditarViewModel);
            }
            _racaService.Editar(racaEditarViewModel);

            return RedirectToAction("Index");
        }

        private List<string> ObterEspecies()
        {
            return Enum.GetNames<Especie>().OrderBy(x => x).ToList();
        }
    }
}