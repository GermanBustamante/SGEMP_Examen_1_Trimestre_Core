using SGEMP_Examen_1_Trimestre_Core_BL.Listados;
using SGEMP_Examen_1_Trimestre_Entidades;
using System.Collections.Generic;

namespace SGEMP_Examen_1_Trimestre_Core_UI.Models.ViewModels
{
    public class clsListadoCategoriasVM
    {
        #region propiedades publicas
        public List<clsCategoria> ListadoCategorias { get; set; }
        #endregion
        #region constructores

        public clsListadoCategoriasVM()
        {
            ListadoCategorias = clsListadoCategoriasBL.getListadoCompletoCategoriasBL();
        }
        #endregion
    }
}
