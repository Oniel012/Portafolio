using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using Portafolio.Services.Interface;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService _serviceHome;

        public HomeController(ILogger<HomeController> logger, IHomeService serviceHome )
        {
            _logger = logger;
            _serviceHome = serviceHome;
        }
        //SOLID = s = Single Resposability, O = Open / clouse, L = Liskov Sustitution, I = Interfase Segregation, D = Dependecy inversion
        public IActionResult Index()
        {
               
            var proyecDto = _serviceHome.Proyects().Take(3).ToList();
            var model = new ProyectViewModel() { Proyects = proyecDto };
            
                
            return View(model);
        }

       
        public IActionResult Privacy()
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