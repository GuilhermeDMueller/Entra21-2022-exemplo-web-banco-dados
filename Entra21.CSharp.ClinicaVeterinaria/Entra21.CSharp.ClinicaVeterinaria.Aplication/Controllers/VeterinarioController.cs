using Entra21.CSharp.ClinicaVeterinaria.Service;
using Entra21.CSharp.ClinicaVeterinaria.Service.ViewModels.Veterinarios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplication.Controllers
{
    [Route("/veterinario")]
    public class VeterinarioController : Controller
    {
        private readonly IVeterinarioServico _veterinarioService;

        public VeterinarioController(IVeterinarioServico veterinarioService)
        {
            _veterinarioService = veterinarioService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/cadastrar")]
        public IActionResult Cadastrar(
            VeterinarioCadastrarViewModel veterinarioCadastrarViewModel)
        {
            if (!ModelState.IsValid)
                return View(veterinarioCadastrarViewModel);

            // Criar o registro chamando o serviço
            _veterinarioService.Cadastrar(veterinarioCadastrarViewModel);

            // Redireciona para index
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }
    }
}