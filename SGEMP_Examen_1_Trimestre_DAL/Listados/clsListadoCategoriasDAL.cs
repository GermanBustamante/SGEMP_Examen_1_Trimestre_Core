using SGEMP_Examen_1_Trimestre_DAL.Utilidades;
using SGEMP_Examen_1_Trimestre_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMP_Examen_1_Trimestre_DAL.Listados
{
    public class clsListadoCategoriasDAL : ClsUtililidadSelectDAL
    {

        #region metodos publicos
        /// <summary>
        /// Abre una conexión a la BD, ejecuta una instrucción select para devolver una lista de categorías de toda la tabla Categorias y cierra los flujos, luego devuelve dicha lista leida del lector
        /// </summary>
        /// <returns></returns>
        public static List<clsCategoria> getListadoCompletoCategoriasBL()
        {
            List<clsCategoria> listadoCategorias = null;
            instanciarConexion();
            MiLector = ejecutarSelect("SELECT * FROM categorias");
            if (MiLector.HasRows)
            {
                listadoCategorias = getListadoCategoriasMiLector();
            }
            cerrarFlujos();
            return listadoCategorias;
        }
        #endregion
        #region metodos privados
        private static List<clsCategoria> getListadoCategoriasMiLector()
        {
            List<clsCategoria> listadoCategorias = new List<clsCategoria>();
            while (MiLector.Read())
            {
                listadoCategorias.Add(getCategoriaMiLector());
            }
            return listadoCategorias;
        }

        private static clsCategoria getCategoriaMiLector()
        {
            clsCategoria oCategoria = new clsCategoria();
            oCategoria.IdCategoria = (int)MiLector["idCategoria"];
            oCategoria.NombreCategoria = (string)MiLector["nombreCategoria"];

            return oCategoria;
        }
        #endregion
    }
}
