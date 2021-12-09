using SGEMP_Examen_1_Trimestre_DAL.Utilidades;
using SGEMP_Examen_1_Trimestre_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMP_Examen_1_Trimestre_DAL.Manejadoras
{
    public class clsManejadoraPlantasDAL : ClsUtilidadDMLDAL
    {
        /// <summary>
        /// Dado una planta, abre un flujo a la BD, actualiza el precio y retorna el numero de filas afectadas, ademas de cerrar el flujo
        /// </summary>
        /// <param name="oPlanta"></param>
        /// <returns></returns>
        public static int actualizarPrecioPlantaDAL(clsPlanta oPlanta)
        {
            instanciarConexion();
            MiComando.Parameters.Add("@idPlanta", System.Data.SqlDbType.Int).Value = oPlanta.IdPlanta;
            MiComando.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = oPlanta.Precio;
            int resultado = ejecutarSentenciaDML("UPDATE plantas SET precio = @precio WHERE idPlanta = @idPlanta");
            MiConexion.closeConnection();
            return resultado;
        }
    }
}
