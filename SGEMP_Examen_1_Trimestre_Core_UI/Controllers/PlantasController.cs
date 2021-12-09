using Microsoft.AspNetCore.Mvc;
using SGEMP_Examen_1_Trimestre_Core_BL.Listados;
using SGEMP_Examen_1_Trimestre_Core_BL.Manejadoras;
using SGEMP_Examen_1_Trimestre_Core_UI.Models.ViewModels;
using SGEMP_Examen_1_Trimestre_Entidades;
using System.Data.SqlClient;

namespace SGEMP_Examen_1_Trimestre_Core_UI.Controllers
{
    public class PlantasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListadoPlantasPorCategoria (int idCategoria)
        {
            IActionResult actionResult = null;
            try
            {
                clsListadoPlantasPorCategoriaVM oListadoPlantasPorCategoriaVM = new clsListadoPlantasPorCategoriaVM(idCategoria);
                actionResult = View(oListadoPlantasPorCategoriaVM.ListadoPlantasCategoria);
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                actionResult = View("Error");
            }
            return actionResult;
        }

        public IActionResult EditarPrecioPlanta(int idPlanta)
        {
            IActionResult actionResult = null;
                try
            {
                clsPlanta oPlanta = clsListadoPlantasBL.getPlantaCompletaDadoIdBL(idPlanta);
                actionResult = View(oPlanta);
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                actionResult = View("Error");
            }
            return actionResult;
        }

        [HttpPost]
        public IActionResult EditarPrecioPlanta(clsPlanta oPlanta)
        {
            IActionResult actionResult = null;
            if (!ModelState.IsValid)
            {
                //TODO ESTO NO ES DEL TODO CORRECTO YA QUE EL PARÁMETRO DEBERÍA RECOGER EL OBJETO PLANTA CON LA DESCRIPCIÓN Y EL NOMBRE PARA NO TENER QUE LLAMAR DE NUEVO A LA BD, CAMBIAR SI DA TIEMPO
                actionResult = View("EditarPrecioPlanta", clsListadoPlantasBL.getPlantaCompletaDadoIdBL(oPlanta.IdPlanta));
            }
            else
            {
                try
                {
                    ViewBag.NumeroFilasAfectadas = clsManejadoraPlantasBL.actualizarPrecioPlantaBL(oPlanta);
                    actionResult = View(clsListadoPlantasBL.getPlantaCompletaDadoIdBL(oPlanta.IdPlanta));
                }
                catch (SqlException ex)
                {
                    ViewBag.ErrorMsg = ex.Message;
                    actionResult = View("Error");
                }
            }
            return actionResult;
        }

    }
}
