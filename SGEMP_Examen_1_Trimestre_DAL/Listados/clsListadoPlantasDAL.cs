using SGEMP_Examen_1_Trimestre_DAL.Utilidades;
using SGEMP_Examen_1_Trimestre_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMP_Examen_1_Trimestre_DAL.Listados
{
    public class clsListadoPlantasDAL : ClsUtililidadSelectDAL
    {
        #region metodos publicos
        /// <summary>
        /// Dado el id de una categoria, abre el flujo a la BD, recoge las plantas que pertenezcan a dicha categoria, las añade a una lista, cierra el flujo y retorna dicha lista
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <returns></returns>
        public static List<clsPlanta> getListadoPlantasIdPlantaYNombreDadoIdCategoriaDAL(int idCategoria)
        {
            List<clsPlanta> listadoPlantas = null;
            instanciarConexion();
            MiLector = ejecutarSelectCondicion("SELECT idPlanta, nombrePlanta FROM plantas WHERE idCategoria= ", idCategoria);
            if (MiLector.HasRows)
            {
                listadoPlantas = getListadoPlantasIdPlantaYNombreMiLector();
            }
            cerrarFlujos();
            return listadoPlantas;
        }

        /// <summary>
        /// Dado el id de una planta, ejecuta una consulta, reconstruye la planta recogida, cierra el flujo y retorna dicho objeto Planta
        /// </summary>
        /// <param name="idPlanta"></param>
        /// <returns></returns>
        public static clsPlanta getPlantaCompletaIdDAL(int idPlanta)
        {
            clsPlanta oPlantaRecogida = new clsPlanta();
            instanciarConexion();
            MiLector = ejecutarSelectCondicion("SELECT * FROM plantas WHERE idPlanta = ", idPlanta);
            if (MiLector.HasRows)
            {
                MiLector.Read();
                oPlantaRecogida = getPlantaCompletaMiLector();
            }
            cerrarFlujos();
            return oPlantaRecogida;
        }
        #endregion

        #region metodos privados
        private static List<clsPlanta> getListadoPlantasIdPlantaYNombreMiLector()
        {
            List<clsPlanta> listadoPlantas = new List<clsPlanta>();
            while (MiLector.Read())
            {
                listadoPlantas.Add(getPlantaIdPlantaYNombreMiLector());
            }
            return listadoPlantas;
        }

        private static clsPlanta getPlantaIdPlantaYNombreMiLector()
        {
            clsPlanta oPlanta = new clsPlanta();
            oPlanta.IdPlanta = (int)MiLector["idPlanta"];
            oPlanta.Nombre = (string)MiLector["nombrePlanta"];
            return oPlanta;
        }

        private static clsPlanta getPlantaCompletaMiLector()
        {
            clsPlanta oPlantaRecogida = new clsPlanta();
            oPlantaRecogida.IdPlanta = (int)MiLector["idPlanta"];
            oPlantaRecogida.Nombre = (string)MiLector["nombrePlanta"];
            if (MiLector["descripcion"] != DBNull.Value)
            {
                oPlantaRecogida.Descripcion = (string)MiLector["descripcion"];
            }
            oPlantaRecogida.IdCategoria = (int)MiLector["idCategoria"];
            if (MiLector["precio"] != DBNull.Value)
            {
                oPlantaRecogida.Precio = (double)MiLector["precio"];
            }
            return oPlantaRecogida;
        }
        #endregion
    }
}
