using SGEMP_Examen_1_Trimestre_DAL.Manejadoras;
using SGEMP_Examen_1_Trimestre_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMP_Examen_1_Trimestre_Core_BL.Manejadoras
{
    public class clsManejadoraPlantasBL
    {
        /// <summary>
        /// LLama a actualizarPrecioPlantaBL(clsPlanta oPlanta) y retorna el entero dado por este, en caso de que existieran reglas de negocio, irían aqui
        /// </summary>
        /// <param name="oPlanta"></param>
        /// <returns></returns>
        public static int actualizarPrecioPlantaBL(clsPlanta oPlanta)
        {
            return clsManejadoraPlantasDAL.actualizarPrecioPlantaDAL(oPlanta);
        }
    }
}
