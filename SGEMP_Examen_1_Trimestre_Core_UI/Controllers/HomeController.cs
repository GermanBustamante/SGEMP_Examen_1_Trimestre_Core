using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGEMP_Examen_1_Trimestre_Core_UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SGEMP_Examen_1_Trimestre_Core_UI.Controllers
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
            SGEMP_Examen_1_Trimestre_DAL.Conexion.ClsMyConnection clsMyConnection = new SGEMP_Examen_1_Trimestre_DAL.Conexion.ClsMyConnection();
            clsMyConnection.getConnection();
            
            return View();
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
