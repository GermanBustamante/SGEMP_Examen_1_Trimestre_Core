using SGEMP_Examen_1_Trimestre_DAL.Listados;
using SGEMP_Examen_1_Trimestre_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMP_Examen_1_Trimestre_Core_BL.Listados
{
    public class clsListadoCategoriasBL
    {
        /// <summary>
        /// Llama a getListadoCompletoCategoriasBL(), y retorna la lista dada por este, en caso de que existiera alguna regla de negocio, la pondríamos aquí
        /// </summary>
        /// <returns></returns>
        public static List<clsCategoria> getListadoCompletoCategoriasBL()
        {
            return clsListadoCategoriasDAL.getListadoCompletoCategoriasBL();
        }
    }
}
