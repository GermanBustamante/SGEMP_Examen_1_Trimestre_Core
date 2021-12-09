using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGEMP_Examen_1_Trimestre_Entidades
{
    public class clsPlanta
    {
        #region propiedades publicas
        public int IdPlanta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "El precio no puede dejarse vacío")]
        public double Precio { get; set; }
        #endregion
        #region constructores
        public clsPlanta(int idPlanta, string nombre, string descripcion, int idCategoria, double precio)
        {
            IdPlanta = idPlanta;
            Nombre = nombre;
            Descripcion = descripcion;
            IdCategoria = idCategoria;
            Precio = precio;
        }

        public clsPlanta()
        {
        }

        //Constructor para la vista editar planta, ya que en esa vista solo puedo editar el precio, además de necesitar su id para saber cual cambiar
        public clsPlanta (int idPlanta, double precio)
        {
            IdPlanta = idPlanta;
            Precio = precio;
        }

        public clsPlanta(int idPlanta, string nombre, string descripcion, int idCategoria)
        {
            IdPlanta = idPlanta;
            Nombre = nombre;
            Descripcion = descripcion;
            IdCategoria = idCategoria;
        }
        #endregion
    }
}
