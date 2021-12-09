using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMP_Examen_1_Trimestre_Entidades
{
    public class clsCategoria
    {
        #region propiedades publicas
        public int IdCategoria{ get; set; }
        public string NombreCategoria { get; set; }
        #endregion
        #region constructores
        public clsCategoria(int idCategoria, string nombreCategoria)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
        }

        public clsCategoria()
        {
        }
        #endregion
    }
}
