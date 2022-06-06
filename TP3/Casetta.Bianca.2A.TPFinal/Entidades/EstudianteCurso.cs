using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudianteCurso : Estudiante
    {
        protected Curso curso;

        public EstudianteCurso()
        {

        }
        public EstudianteCurso(string nombre, string apellido, int dni, DateTime fechaNacimiento, string genero, double telefono, Domicilio domicilio, ETipoEstudiante tipo, string eMail, Curso curso)
            : base(nombre, apellido, dni, fechaNacimiento, genero, telefono, domicilio, tipo, eMail)
        {
            this.curso = curso;
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de curso
        /// </summary>
        public Curso Curso
        {
            get
            {
                return this.curso;
            }
            set
            {
                this.curso = value;
            }
        }

        /// <summary>
        /// Muestra la información de un EstudianteCurso según el formato asignado. Recupera los datos de la clase abstracta y agrega lo que corresponda según la clase.
        /// </summary>
        /// <returns>Una string con los datos del EstudianteCurso</returns>
        public override string ToString()
        {
            StringBuilder datosCurso = new StringBuilder();
            datosCurso.Append(base.ToString());
            datosCurso.AppendLine($"CURSO: {this.Curso.Nivel}");

            return datosCurso.ToString();
        }
    }
}
