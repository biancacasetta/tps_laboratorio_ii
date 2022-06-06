using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudianteParticular : Estudiante
    {
        protected const int precioHora = 1200;

        public EstudianteParticular()
        {

        }
        public EstudianteParticular(string nombre, string apellido, int dni, DateTime fechaNacimiento, string genero, double telefono, Domicilio domicilio, ETipoEstudiante tipo, string eMail)
            : base(nombre, apellido, dni, fechaNacimiento, genero, telefono, domicilio, tipo, eMail)
        {

        }

        /// <summary>
        /// Propiedad de lectura para el atributo de precioHora.
        /// No se puede asignar valor porque es una constante, pero es necesario dejar el set para la serialización.
        /// </summary>
        public int PrecioHora
        {
            get
            {
                return precioHora;
            }
            set
            {
                ;
            }
        }

        /// <summary>
        /// Muestra la información de un EstudianteParticular según el formato asignado. Recupera los datos de la clase abstracta y agrega lo que corresponda según la clase.
        /// </summary>
        /// <returns>Una string con los datos del EstudianteParticular</returns>
        public override string ToString()
        {
            StringBuilder datosParticular = new StringBuilder();
            datosParticular.Append(base.ToString());
            datosParticular.AppendLine($"PRECIO POR HORA: {this.PrecioHora}");

            return datosParticular.ToString();
        }
    }
}
