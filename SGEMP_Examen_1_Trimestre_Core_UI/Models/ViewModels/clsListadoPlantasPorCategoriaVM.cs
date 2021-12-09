using SGEMP_Examen_1_Trimestre_Core_BL.Listados;
using SGEMP_Examen_1_Trimestre_Entidades;
using System.Collections.Generic;

namespace SGEMP_Examen_1_Trimestre_Core_UI.Models.ViewModels
{
    public class clsListadoPlantasPorCategoriaVM
    {
        #region propiedades publicas
        public List<clsPlanta> ListadoPlantasCategoria { get; set; }
        #endregion
        #region constructores

        public clsListadoPlantasPorCategoriaVM()
        {
        }
        public clsListadoPlantasPorCategoriaVM(int idCategoria)
        {
            ListadoPlantasCategoria = clsListadoPlantasBL.getListadoPlantasIdPlantaYNombreDadoIdCategoriaBL(idCategoria);
        }
        #endregion
    }
}
