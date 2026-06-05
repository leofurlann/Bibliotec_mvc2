using Bibliotec_MVC_DEV.Interfaces;
using Bibliotec_MVC_DEV.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotec_MVC_DEV.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IReservaService _reservaService;

        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        public async Task<IActionResult> Index()
        {
            string? adminSessao = HttpContext.Session.GetString("Admin");
            int.TryParse(HttpContext.Session.GetString("UsuarioId"), out int usuarioId);
            if (adminSessao == null || (adminSessao != "true" && adminSessao != "True"))
            {
                return RedirectToAction("Index", "Login");
            }

            

            ViewBag.Admin = true;

            IEnumerable<Reserva> reservas;

            if (ViewBag.Admin) // == true
            {
                reservas = await _reservaService.BuscarReservaAsync();
            }
            else
            {
                reservas = await _reservaService.BuscarReservasPorUsuarioAsync(usuarioId);
            }


            return View(reservas);
        }
    }
}