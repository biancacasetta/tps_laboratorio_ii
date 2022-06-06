using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudianteExterno : Estudiante
    {
        protected ENivel nivel;

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de nivel
        /// </summary>
        public ENivel Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }

        public EstudianteExterno()
        {
                
        }
        public EstudianteExterno(string nombre, string apellido, int dni, DateTime fechaNacimiento, string genero, double telefono, Domicilio domicilio, ETipoEstudiante tipo, ENivel nivel, string eMail)
            : base(nombre, apellido, dni, fechaNacimiento, genero, telefono, domicilio, tipo, eMail)
        {
            this.nivel = nivel;
        }

        /// <summary>
        /// Muestra la información de un EstudianteExterno según el formato asignado. Recupera los datos de la clase abstracta y agrega lo que corresponda según la clase.
        /// </summary>
        /// <returns>Una string con los datos del EstudianteExterno</returns>
        public override string ToString()
        {
            StringBuilder datosExterno = new StringBuilder();
            datosExterno.Append(base.ToString());
            datosExterno.AppendLine($"NIVEL: {this.Nivel}");

            return datosExterno.ToString();
        }
    }
}
