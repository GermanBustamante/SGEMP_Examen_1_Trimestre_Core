using Microsoft.AspNetCore.Mvc;
using SGEMP_Examen_1_Trimestre_Core_UI.Models.ViewModels;
using System.Data.SqlClient;

namespace SGEMP_Examen_1_Trimestre_Core_UI.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Index()
        {
            IActionResult actionResult = null;
            try
            {
                clsListadoCategoriasVM oListadoCategoriasVM = new clsListadoCategoriasVM();
                actionResult = View(oListadoCategoriasVM.ListadoCategorias);
            }catch(SqlException ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                actionResult = View("Error");
            }
            return actionResult;
        }
    }
}
