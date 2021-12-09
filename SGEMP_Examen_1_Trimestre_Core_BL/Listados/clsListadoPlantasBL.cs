using SGEMP_Examen_1_Trimestre_DAL.Listados;
using SGEMP_Examen_1_Trimestre_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMP_Examen_1_Trimestre_Core_BL.Listados
{
    public class clsListadoPlantasBL
    {
        /// <summary>
        /// Llama a y getListadoPlantasIdPlantaYNombreDadoIdCategoriaDAL(idCategoria) retorna la lista dada por este, en caso de que existiera alguna regla de negocio, la pondríamos aquí
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <returns></returns>
        public static List<clsPlanta> getListadoPlantasIdPlantaYNombreDadoIdCategoriaBL(int idCategoria)
        {
            return clsListadoPlantasDAL.getListadoPlantasIdPlantaYNombreDadoIdCategoriaDAL(idCategoria);
        }

        /// <summary>
        /// Llama a getPlantaCompletaDadoIdBL(int idPlanta) y retorna el objeto dado por este , en caso de que existiera alguna regla de negocio, la pondríamos aquí
        /// </summary>
        /// <param name="idPlanta"></param>
        /// <returns></returns>
        public static clsPlanta getPlantaCompletaDadoIdBL(int idPlanta)
        {
            return clsListadoPlantasDAL.getPlantaCompletaIdDAL(idPlanta);
        }
    }
}
