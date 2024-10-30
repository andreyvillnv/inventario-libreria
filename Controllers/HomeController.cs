using inventario_libreria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace inventario_libreria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
 
        public IActionResult Factura()
        {
            return View();
        }

        public IActionResult AcercaDe()
        {
            return View();
        }

        public IActionResult AgregarProductos()
        {
            return View();
        }

        public IActionResult AgregarProveedor()
        {
            return View();
        }

        public IActionResult InicioSesion()
        {
            return View();
        }
        public IActionResult RegistroEmpleado()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
